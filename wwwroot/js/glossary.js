document.addEventListener("DOMContentLoaded", () => {
    if (!window.glossary) return;

    const elements = document.querySelectorAll(".glossary-text, #texte");
    if (!elements.length) return;

    elements.forEach(el => {
        let html = el.innerHTML;

        window.glossary.forEach(word => {
            if (!word.text) return;

            const forms = [word.text];
            if (word.plural) forms.push(word.plural);

            forms.forEach(form => {
                const escaped = form.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
                // Match word at word boundaries OR start of string
                const regex = new RegExp(`(^|\\s)${escaped}(?=\\s|$)`, "gi");

                html = html.replace(regex, match => {
                    if (match.includes('<a ')) return match;
                    return `<a href="${word.link}" class="glossary-link" title="${word.definition}">${match}</a>`;
                });
            });
        });

        el.innerHTML = html;
    });

    const style = document.createElement("style");
    style.textContent = `
    .glossary-link {
        color:red;
          text-decoration: underline;
        cursor: pointer;
        font-weight: bold;
    }

    .glossary-link:hover {
        color: red; /* color when hovering */
    }
`;
    document.head.appendChild(style);


});
