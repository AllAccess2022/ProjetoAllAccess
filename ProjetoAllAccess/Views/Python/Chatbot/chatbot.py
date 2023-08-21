import re
import chatterbot_corpus
import time
time.clock = time.time
import logging  
from chatterbot import ChatBot
chatbot = ChatBot("BOT Gui")
import logging
logging.basicConfig(filename='logDEBUG.log',level=logging.DEBUG)
from chatterbot.trainers import ListTrainer


conversation = [
    "ola", 
    "Olá, meu nome é BOT Gui e estou aqui para te ajudar com suas dúvidas a respeito do projeto.",
    "oi", 
    "Olá, meu nome é BOT Gui e estou aqui para te ajudar com suas dúvidas a respeito do projeto.",
    "eai", 
    "Oi, tudo bem?",
    "Bom dia",
    "Bom dia, como posso te ajudar?",
    "Boa tarde",
    "Bom tarde, como posso te ajudar?",
    "Boa noite" 
    "Bom noite, como posso te ajudar?",
    "boa noite",
    "Bom noite, como posso te ajudar?",
    "O que você faz?",
    "Eu sou o chatbot do projeto de TCC do Guilherme Ometto sobre TDAH.",
    "Oq vc faz",
    "Eu sou o chatbot do projeto de TCC do Guilherme Ometto sobre TDAH.",
    "Que legal",
    "Muito obrigado!",
    "qual seu nome?",
    "BOT Gui",
    "Pode me ajudar?",
    "Claro, o que você precisa?",
    "O que é TDAH?",
    "TDAH significa Transtorno do Déficit de Atenção com Hiperatividade. É um transtorno neurobiológico que afeta a atenção, impulsividade e hiperatividade.",
    "Qual o intuito do projeto?",
    "O projeto tem como obejtivo criar uma plataforma acolhedora e informativa sobre TDAH, criando a oportunidade dos usuários se comunicarem pela comunidade do Discord.",
    "Os sintomas comuns do TDAH incluem dificuldade de concentração, impulsividade, hiperatividade, desorganização e dificuldades em seguir instruções.",
    "Como é feito o diagnóstico do TDAH?",
    "O diagnóstico do TDAH é feito por um profissional de saúde mental, que irá avaliar os sintomas do paciente, histórico médico e comportamental. Testes psicológicos e avaliações neurológicas também podem ser realizados.",
    "Quais são os tratamentos disponíveis para o TDAH?",
    "Os tratamentos para TDAH incluem medicamentos estimulantes e não estimulantes, terapia comportamental e aconselhamento.",
    "Como o TDAH afeta o desempenho acadêmico e profissional?",
    "O TDAH pode afetar negativamente o desempenho acadêmico e profissional, uma vez que pode ser difícil para a pessoa se concentrar, seguir instruções e organizar tarefas.",
    "Existem estratégias eficazes para lidar com o TDAH?",
    "Sim, existem diversas estratégias que podem ajudar a pessoa com TDAH, como a utilização de agendas e listas de tarefas, ter rotinas diárias, criar um ambiente organizado e evitar distrações.",
    "Como os pais podem ajudar crianças com TDAH em casa e na escola?",
    "Os pais podem ajudar as crianças com TDAH em casa e na escola criando um ambiente estruturado, oferecendo apoio emocional e ajudando a criança a desenvolver habilidades sociais e de organização.",
    "Quais são as comorbidades frequentemente associadas ao TDAH?",
    "As comorbidades frequentemente associadas ao TDAH incluem transtornos de ansiedade, depressão, transtorno opositor desafiador e transtornos do sono.",
    "Como o TDAH é visto em diferentes culturas?",
    "O TDAH é visto de forma semelhante em diferentes culturas, embora as estratégias de tratamento e a aceitação cultural possam variar.",
    "Quais são os mitos comuns sobre o TDAH e como desmistificá-los?",
    "Alguns mitos comuns sobre o TDAH incluem a ideia de que o transtorno não é real ou que é causado por pais negligentes. Esses mitos podem ser desmistificados com informações precisas e cientificamente comprovadas sobre o transtorno.",
    "Quais são as últimas pesquisas em relação ao TDAH?",
    "As últimas pesquisas em relação ao TDAH incluem estudos sobre a eficácia de diferentes tratamentos, como medicamentos e terapia comportamental, e estudos sobre a relação entre o TDAH e outras condições de saúde mental.",
    ]

my_bot = ChatBot(name='BOT Gui', read_only=True,
                 logic_adapters=
                 ['chatterbot.logic.MathematicalEvaluation',
                  'chatterbot.logic.BestMatch'])

from chatterbot.trainers import ChatterBotCorpusTrainer
corpus_trainer = ChatterBotCorpusTrainer(chatbot)
corpus_trainer.train('chatterbot.corpus.portuguese')

trainer = ListTrainer(chatbot)
trainer.train(conversation)

while True:
    pergunta = input("Usuário: ")
    resposta = chatbot.get_response(pergunta)
    if float(resposta.confidence) > 0.3:
        print('BOT Gui: ', resposta)
    else:
        print('BOT Gui: Ainda não sei responder esta pergunta.')