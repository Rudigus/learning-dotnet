CREATE DATABASE Faculdade;

GO

USE Faculdade;

CREATE TABLE Alunos (
	Matricula int not null primary key,
	Nome varchar(30) not null,
	Curso varchar(30) not null,
	DataNascimento date not null
);

CREATE TABLE Turmas (
	 NumeroTurma int not null primary key,
	 Nome varchar(30) not null,
	 Sala varchar(20) not null,
	 Horario time not null
);

INSERT INTO Alunos VALUES (1, 'Anderson', 'Psicologia', '1999-02-01');
INSERT INTO Alunos VALUES (2, 'Renato', 'Direito', '1993-08-05');
INSERT INTO Alunos VALUES (3, 'Patrícia', 'Odontologia', '1990-12-24');

INSERT INTO Turmas VALUES (1, 'Banco de Dados', 'BDI 202', '16:00:00');
INSERT INTO Turmas VALUES (2, 'Filosofia', 'BDI 442', '18:00:00');
INSERT INTO Turmas VALUES (3, 'Probabilidade e Estatística', 'BDI 129', '13:30:00');

SELECT * FROM Alunos;
SELECT * FROM Turmas;