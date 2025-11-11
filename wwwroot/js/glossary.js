document.addEventListener("DOMContentLoaded", () => {
    if (!window.glossary) return;

    const elements = document.querySelectorAll(".glossary-text, #texte");
    if (!elements.length) return;

    elements.forEach(el => {
        // Skip if element is inside a glossary entry
        if (el.closest('.glossary-entry')) return '';

        let html = el.innerHTML;

        window.glossary.forEach(word => {
            if (!word.text) return;

            const forms = [word.text];
            if (word.plural) forms.push(word.plural);

            forms.forEach(form => {
                const escaped = form.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
                const regex = new RegExp(`\\b${escaped}\\b`, "gi");

                html = html.replace(regex, match => {
                    // Simple replacement
                    return `<a href="${word.link}" class="glossary-link" title="${word.definition}">${match}</a>`;
                });
            });
        });

        el.innerHTML = html;
    });



    // Add styles
    const style = document.createElement("style");
    style.textContent = `
        .glossary-link {
            color: red;
            text-decoration: underline dotted;
            cursor: pointer;
            font-weight: bold;
        }
    `;
    document.head.appendChild(style);
});
