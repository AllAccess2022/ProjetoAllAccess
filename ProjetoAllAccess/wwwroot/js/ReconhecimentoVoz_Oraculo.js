const startButton = document.getElementById('startButton');
const stopButton = document.getElementById('stopButton');
const outputTextarea = document.getElementById('txtMsg');
let recognition;

stopButton.style.display = 'none';

startButton.addEventListener('click', () =>
{
    if ('SpeechRecognition' in window || 'webkitSpeechRecognition' in window)
    {
        recognition = new (window.SpeechRecognition || window.webkitSpeechRecognition)();

        // Configurar o idioma para português do Brasil
        recognition.lang = 'pt-BR';

        recognition.onresult = (event) =>
        {
            const transcript = event.results[0][0].transcript;

            // Remover o último caractere (ponto) se existir
            const cleanedTranscript = transcript.replace(/\.$/, '');

            outputTextarea.value = cleanedTranscript;
        };

        recognition.onend = () =>
        {
            startButton.style.display = 'inline-block';
            stopButton.style.display = 'none';
        };

        recognition.start();
        startButton.style.display = 'none';
        stopButton.style.display = 'inline-block';
    } else
    {
        alert('Seu navegador não suporta a API de Reconhecimento de Voz.');
    }
});

stopButton.addEventListener('click', () =>
{
    if (recognition)
    {
        recognition.stop();
        startButton.style.display = 'inline-block';
        stopButton.style.display = 'none';
    }
});
