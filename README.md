# Demonstração dos Princípios SOLID em C#

Este projeto exemplifica os cinco princípios SOLID de design orientado a objetos com exemplos em C#, mostrando tanto as violações quanto as soluções para cada princípio.

## Princípios Demonstrados

1. **SRP** (Princípio da Responsabilidade Única)
   - Violação: Classe `User` manipulando dados e persistência
   - Solução: Separar em `UserRepository` e `EmailService`

2. **OCP** (Princípio Aberto/Fechado)
   - Violação: `AreaCalculator` com lógica condicional
   - Solução: Classe abstrata `Shape` com polimorfismo

3. **LSP** (Princípio da Substituição de Liskov)
   - Violação: `Square` herdando de `Rectangle` com comportamento modificado
   - Solução: Classe base `Shape` separada

4. **ISP** (Princípio da Segregação de Interfaces)
   - Violação: `IWork` com métodos não utilizados por todos
   - Solução: Dividir em `IWork` e `ILivingBeing`

5. **DIP** (Princípio da Inversão de Dependência)
   - Violação: Classe `Notification` dependendo de `EmailService` concreto
   - Solução: Depender da abstração `IMessageService`

## Estrutura do Projeto

    SOLID/  
    ├── DIP/  
    │ ├── Violation.cs  
    │ └── Solution.cs  
    ├── ISP/  
    │ ├── Violation.cs  
    │ └── Solution.cs  
    ├── LSP/  
    │ ├── Violation.cs  
    │ └── Solution.cs  
    ├── OCP/  
    │ ├── Violation.cs  
    │ └── Solution.cs  
    ├── SRP/  
    │ ├── Violation.cs  
    │ └── Solution.cs  
    ├── Program.cs  
    └── README.md


## Como Executar

1. Clone o repositório
2. Abra no Visual Studio
3. Compile e execute o projeto

O programa demonstrará cada princípio SOLID com exemplos práticos.


## Conclusão

Este projeto demonstra de forma prática a importância dos princípios SOLID no desenvolvimento de software:

-   **Código mais organizado**: Cada princípio ajuda a criar uma estrutura mais limpa e modular
    
-   **Facilidade de manutenção**: As soluções mostram como evitar problemas comuns de design
    
-   **Escalabilidade**: Aplicando esses conceitos, o código se torna mais fácil de estender
    
-   **Boas práticas**: Fundamentos essenciais para qualquer desenvolvedor OOP
    

Os exemplos apresentados ilustram tanto os erros comuns (violações) quanto as melhores práticas (soluções), servindo como:

1.  Material de aprendizado para quem está estudando SOLID
    
2.  Referência rápida para revisão de conceitos
    
3.  Base para discussões sobre arquitetura de software
    

Lembre-se que a aplicação dos princípios SOLID deve ser equilibrada - o objetivo é criar software de qualidade, não apenas seguir regras rigidamente.

"Primeiro faça funcionar, depois faça certo e então faça rápido." - Kent Beck

Este projeto cumpre a segunda etapa - mostrar como "fazer certo" através dos princípios SOLID.
