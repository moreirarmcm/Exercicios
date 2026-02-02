# Exercicios
Exercícios de programação

#1 - Sistema de usuários e produtos
Atividade: criar uma API simples para cadastramento de usuários e produtos.
Tecnologias utilizadas: .NET 8, banco de dados (livre),

Comentários: A gestão do tempo foi um problema (a camada de dados e banco de dados consumiu +- 1h40), o que acabou faltando para as camadas superiores. Precisei priorizar a funcionalidade e entrega, mesmo deixando um pouco na parte de polimento mais profundo.
Ex: a modelagem doi feita diretamente nos scrips (não fiz modelo conceitual), as procedures de busca foram reutilizadas. Houve alguns problemas durante o desenvolvimento, mas mantive para evitar retrabalho (e consumir o tempo restante);
Durante o desenvolvimento da camada de negócio, percebi que que algumas entidades estavam sendo expostas para a camada de API (inadimssível). Ajustei enquanto de desenvolvia e testava (apenas na controller Usuario). Para corrigir isso, foi introduzida a camada de DTOs (Contratos) em um estágio mais avançado do desenvolvimento, o que pode ter gerado pequenas inconsistências entre métodos e contratos. (idealmente, eu faria essa separação no início do desenvoliemnto).
No momento da construção da classe Usuario, optei escrever a lógica de hash/salt direto no método, sem interface e implementação separada. Fiz isso por conta do tempo.
A API foi feita nos ultimos momentos, portanto não me preocupei em refinar os retornos dos endpoints: meu intuito foi entregar com os endipoints funcionando corretamente.
O fluxo de Produto não foi testado devido à limitação de tempo.

Com mais tempo disponível, os pontos listados acima seriam priorizados para refatoração, padronização e documentação adicional.

