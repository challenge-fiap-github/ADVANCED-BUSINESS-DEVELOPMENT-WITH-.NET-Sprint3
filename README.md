# OdontoVision


## 👥 Equipe
| Matrícula  | Nome                              |
|------------|-----------------------------------|
| **553568** | Sabrina da Motta Café            |
| **552692** | Luís Henrique Oliveira Da Silva  |
| **554199** | Matheus Duarte Oliveira          |

---

## Descrição do Projeto

OdontoVision é um sistema desenvolvido para facilitar a gestão de informações em clínicas odontológicas. A solução é composta por uma API desenvolvida em ASP.NET Core Web API, que permite que dentistas cadastrem informações sobre diagnósticos, pacientes, procedimentos e outros dados relevantes.

O sistema utiliza o banco de dados Oracle para armazenar as informações e implementa os principais padrões de projeto para garantir manutenibilidade e escalabilidade.

## Arquitetura do Sistema

### Escolha da Arquitetura Monolítica

A arquitetura monolítica foi escolhida para o OdontoVision devido a diversos fatores, incluindo:

- **Simplicidade no desenvolvimento**: A estrutura monolítica facilita a implementação e manutenção do sistema, pois todos os componentes estão localizados no mesmo código base.
    
- **Baixa complexidade operacional**: Ao contrário de arquiteturas baseadas em microservices, um sistema monolítico evita a necessidade de gerenciar várias instâncias de serviços independentes.
    
- **Facilidade de deploy**: Com apenas um binário, o deploy é mais simples e reduz os custos operacionais.
    
- **Baixo volume de acessos simultâneos**: Como a aplicação é voltada para uso interno em clínicas odontológicas, não há uma demanda tão alta de escalabilidade a ponto de justificar a adoção de microservices.
    
- **Eficiência na comunicação entre módulos**: Em um monolito, os módulos interagem diretamente sem a necessidade de comunicação entre redes, o que melhora a performance e reduz a latência.
    

Caso haja necessidade de maior escalabilidade no futuro, a aplicação pode ser migrada para uma arquitetura baseada em microsserviços.

## Tecnologias Utilizadas

- **ASP.NET Core Web API** - Framework para criação de APIs RESTful
    
- **Entity Framework Core** - ORM para interação com banco de dados
    
- **Oracle Database** - Banco de dados relacional utilizado para armazenar as informações
    
- **Swagger/OpenAPI** - Ferramenta para documentação e testes da API
    

## Instalação e Configuração

### Requisitos

- .NET 8.0 instalado
    
- Oracle Database configurado
    
- Postman ou outra ferramenta para testes de API
    

### Passos para Execução

1. Clonar o repositório:
    
2. Restaurar dependências:
    
3. Configurar o banco de dados no `appsettings.json`:
    
4. Executar as migrações do banco de dados:
    
5. Iniciar a aplicação:
    
6. Acessar o Swagger para testar os endpoints: http://localhost:5094/swagger
    

## Endpoints da API

### Dentistas

- `GET /api/Dentista` - Lista todos os dentistas
    
- `GET /api/Dentista/{id}` - Obtém um dentista por ID
    
- `POST /api/Dentista` - Adiciona um novo dentista
    
- `PUT /api/Dentista/{id}` - Atualiza os dados de um dentista
    
- `DELETE /api/Dentista/{id}` - Remove um dentista
    

### Pacientes

- `GET /api/Paciente` - Lista todos os pacientes
    
- `GET /api/Paciente/{id}` - Obtém um paciente por ID
    
- `POST /api/Paciente` - Adiciona um novo paciente
    
- `PUT /api/Paciente/{id}` - Atualiza os dados de um paciente
    
- `DELETE /api/Paciente/{id}` - Remove um paciente
    

### Diagnósticos

- `GET /api/Diagnostico` - Lista todos os diagnósticos
    
- `GET /api/Diagnostico/{id}` - Obtém um diagnóstico por ID
    
- `POST /api/Diagnostico` - Adiciona um novo diagnóstico
    
- `PUT /api/Diagnostico/{id}` - Atualiza um diagnóstico
    
- `DELETE /api/Diagnostico/{id}` - Remove um diagnóstico
    

### Procedimentos

- `GET /api/Procedimento` - Lista todos os procedimentos
    
- `GET /api/Procedimento/{id}` - Obtém um procedimento por ID
    
- `POST /api/Procedimento` - Adiciona um novo procedimento
    
- `PUT /api/Procedimento/{id}` - Atualiza um procedimento
    
- `DELETE /api/Procedimento/{id}` - Remove um procedimento
    

## Contribuição

Contribuições são bem-vindas. Para contribuir:

1. Faça um fork do repositório
    
2. Crie uma nova branch (`git checkout -b feature/nova-funcionalidade`)
    
3. Commit suas alterações (`git commit -m 'Adiciona nova funcionalidade'`)
    
4. Faça push da branch (`git push origin feature/nova-funcionalidade`)
    
5. Abra um Pull Request
    

## Licença

Este projeto está sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.
