# Controle de Tarefas

## Descrição
Esse projeto foi desenvolvido durante o curso de Análise e Desenvolvimento de Sistemas, utilizando o C#, para realizar o controle de tarefas de colaboradores em um ambiente corporativo ou comercial.

## Funcionalidades
`*` Cadastro de funcionários<br>
`*` Cadastro de tarefas<br>
`*` Pesquisa de tarefas<br> 
`*` Edição de informações dos funcionários e das tarefas<br>

## Instruções de uso
### Banco de dados
Como se trata de uma aplicação completa, é necessário a criação de um banco de dados, para que as informações fiquem salvas.
Para esse projeto, foi utilizando o MySql.

### Criação do banco de dados
Utilizando o banco de dados MySql.<br>

CREATE DATABASE pcomercial;


CREATE TABLE funcionarios (<br>
    codigo INT PRIMARY KEY AUTO_INCREMENT,<br>
    nome (VARCHAR 100),<br> 
    cargo (VARCHAR 80)<br>
);

CREATE TABLE tarefas (<br>
    codigo INT PRIMARY KEY AUTO_INCREMENT,<br>
    fucionario INT,<br>
    data_tarefa (VARCHAR 20),<br>
    hora (VARCHAR 8),<br>
    descricao (VARCHAR 100),<br>
    concluido (BOOLEAN)<br>
    FOREIGN KEY (funcionario) REFERENCES funcionarios(codigo)<br>
);

### Teste e Execução
Basta abrir o projeto e executa-lo.<br>
É recomendado que o banco de dados já tenha sido criado.

### Futuras implementações
Criação do executável.




    
