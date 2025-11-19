document.addEventListener("DOMContentLoaded", () => {
    if (!window.glossary) return;

    const elements = document.querySelectorAll(".glossary-text, #texte");
    if (!elements.length) return;

    // normalize to match the id generation used in Views/Conclusion/Glossary.cshtml
    const normalizeId = (s) => {
        if (!s) return "";
        return s.toLowerCase().replace(/[\s-]+/g, "").replace(/[^a-z0-9]/g, "");
    };

    elements.forEach(el => {
        let html = el.innerHTML;

        /* ----------------------------------------------------
           RELATED WORDS (variants → original/base word)
           ---------------------------------------------------- */
        if (window.related) {
            window.related.forEach(rw => {
                if (!rw.variant || !rw.orig) return;

                const escaped = rw.variant.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");

                // match at beginning or after a space, and ending at space or end
                const regex = new RegExp(`(^|\\s)${escaped}(?=\\s|$)`, "gi");

                html = html.replace(regex, match => {
                    if (match.includes("<a ")) return match;
                    // link to the correct controller path and normalized fragment id
                    const frag = normalizeId(rw.orig);
                    return `<a href="/Conclusion/Glossary#${frag}" class="glossary-link">${match}</a>`;
                });
            });
        }

        
        el.innerHTML = html;
    });

    /* ----------------------------------------------------
       LINK STYLE (unchanged from your working version)
       ---------------------------------------------------- */
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
