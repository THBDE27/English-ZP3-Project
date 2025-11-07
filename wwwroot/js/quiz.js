let currentIndex = 0;

function showQuestion(index) {
    const question = questions[index];
    document.getElementById('question-text').textContent = question.Text;

    const optionsDiv = document.getElementById('options');
    optionsDiv.innerHTML = '';

    question.Options.forEach((opt, i) => {
        const btn = document.createElement('button');
        btn.textContent = opt;
        btn.onclick = () => checkAnswer(question.Id, i);
        optionsDiv.appendChild(btn);
    });

    document.getElementById('result').textContent = '';
    const explanation = document.getElementById('explanation');
    explanation.textContent = '';
    explanation.style.display = 'none';

    document.getElementById('next-btn').style.display = 'none';
}

// Check answer function (calls controller)
async function checkAnswer(questionId, selectedOption) {
    const response = await fetch('/HealthBenefits/CheckAnswer', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ questionId, selectedOption })
    });

    const result = await response.json();

    document.getElementById('result').textContent = result.correct ? '✅ Correct!' : '❌ Wrong!';
    const explanation = document.getElementById('explanation');
    explanation.textContent = result.explanation;
    explanation.style.display = 'block';

    document.getElementById('next-btn').style.display = 'inline-block';
}

// Next button handler
document.getElementById('next-btn').onclick = () => {
    currentIndex++;
    if (currentIndex < questions.length) {
        showQuestion(currentIndex);
    } else {
        document.getElementById('quiz-container').innerHTML = `<h2>Quiz complete!</h2>`;
        document.getElementById('next-btn').style.display = 'none';
    }
};

// Show first question on page load
showQuestion(currentIndex);
