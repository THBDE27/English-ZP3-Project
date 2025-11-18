// glossary.js
document.addEventListener("DOMContentLoaded", () => {
    if (!window.glossary || !window.glossary.length) return;

    function escapeRegex(str) {
        return str.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
    }

    function linkTextNode(node) {
        let text = node.nodeValue;
        let original = text;

        window.glossary.forEach(word => {
            if (!word.Text) return;

            // Include plural if available
            const forms = [word.Text];
            if (word.Plural) forms.push(word.Plural);

            forms.forEach(form => {
                const safe = escapeRegex(form);

                // Match the word + optional punctuation
                const pattern = new RegExp(`\\b${safe}\\b([.,!?]?)`, "gi");

                text = text.replace(pattern, (match, punct) => {
                    // Preserve punctuation outside link
                    return `<a href="${word.Link}" class="glossary-link" title="${word.Definition}">${match.slice(0, match.length - punct.length)}</a>${punct}`;
                });
            });
        });

        if (text !== original) {
            const span = document.createElement("span");
            span.innerHTML = text;
            node.replaceWith(span);
        }
    }

    function walk(node) {
        if (node.nodeType === Node.TEXT_NODE) {
            linkTextNode(node);
        } else if (node.nodeType === Node.ELEMENT_NODE && node.tagName.toLowerCase() !== "a") {
            [...node.childNodes].forEach(walk);
        }
    }

    document.querySelectorAll(".glossary-text, #texte").forEach(el => walk(el));

    // Add styles
    const style = document.createElement("style");
    style.textContent = `
        .glossary-link {
            color: lightblue;
            text-decoration: underline;
            cursor: pointer;
            font-weight: bold;
        }
        .glossary-link:hover {
            color: lightblue;
        }
    `;
    document.head.appendChild(style);
});

