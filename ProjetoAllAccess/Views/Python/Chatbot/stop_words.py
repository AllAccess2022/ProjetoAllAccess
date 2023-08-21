from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
from string import punctuation

example_sent = "Oi Guilherme, tudo bem ? Estou aqui para tirar eventuais dúvidas sobre o projeto."

stop_words = set(stopwords.words('portuguese') + list(punctuation))

word_tokens = word_tokenize(example_sent)

filtered_sentence = [w for w in word_tokens if not w in stop_words]

filtered_sentence = []

for w in word_tokens:
    if w not in stop_words:
        filtered_sentence.append(w)

#print(word_tokens)
print(filtered_sentence)