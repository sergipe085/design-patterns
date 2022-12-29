# Contexto
- Imagine um sistema em que teremos uma classe para gerenciar a temperatura e outra para mostrar essa 
temperatura para o cliente (por meio do console ou de uma interface grafica)

# Problema
- Nao queremos acoplar a classe Temperatura `a classe Termometro, pois classes de interface mudam frequentemente (poderemos, mais tarde, 
trocar a interface textual por uma pagina Web)

# Solucao
- Fazer com que as interfaces sejam notificadas sempre q o estado da Temperatura mudar, para isso podemos usar o padrao de projeto Observer e, assim,
a Temperatura nao dependera do Termometro, e sim o contrario (Inversao de Dependencia).
 