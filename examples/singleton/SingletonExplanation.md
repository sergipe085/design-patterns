# Contexto
- Suponha que voce criara uma classe Logger para registrar os Logs da aplicacao.

# Problema
- Seria precisa instanciar uma nova classe Logger sempre que quisessemos fazer um Log na aplicacao. 
- Ainda mais se salvassemos os Logs em arquivos, a criacao de uma nova classe Log apagaria o arquivo anterior.

# Solucao
- Usar o Singleton para permitir no maximo UMA instancia da classe.

# Problemas
- Esse padrao pode ser usado como artificio para criacao de estados globais
- Dificulta os testes de metodo, pois eles dependerao de um estado global na aplicacao (Singleton)