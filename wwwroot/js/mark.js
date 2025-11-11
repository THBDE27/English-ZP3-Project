instance.mark(word.text, {
    className: "glossary-link",
    separateWordSearch: false,
    element: "a",
    attributes: {
        href: word.link,
        title: word.definition,
        target: "_self" // opens in same tab
    },
    acrossElements: true
});
