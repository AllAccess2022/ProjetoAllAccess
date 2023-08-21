#import lib nltk e suas variantes
from nltk.tokenize import sent_tokenize, word_tokenize  
texto  = "Oi Guilherme tudo bem ? Gostaria de saber qual é o propósito do seu TCC." 
print(":::::SENTENCAS:::::")
#funcao para separar o texto em sentencas 
print(sent_tokenize(texto))
print("\n:::::TOKENIZACAO:::::")
#funcao para tokenizar uma frase 
print(word_tokenize(texto))