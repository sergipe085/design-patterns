# Contexto
- Imagine que voce tem que fazer um programa para ligar projetores de diferentes marcas que fornecem diferentes APIs.
- Para isso voce devera utilizar as classes ProjetorSamsung e ProjetorLG fornecidas pelo fabricante.

# Problema 
- Essas classes possuem uma interface diferente com metodos de inicializacao com nomes e parametros diferentes e 
nosso objetivo eh usar uma interface unica para ligar os 2 projetores.

# Solucao
- Criar um adapatador para integrar essas 2 interfaces diferentes em uma unica interface. Veja o exemplo no arquivo AdapterExample.cs