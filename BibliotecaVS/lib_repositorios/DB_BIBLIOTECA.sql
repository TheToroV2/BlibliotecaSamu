--DROP DATABASE DB_BIBLIOTECA

CREATE DATABASE DB_BIBLIOTECA
GO

USE DB_BIBLIOTECA;
GO

-------------------------------------------TABLAS Y RELACIONES

CREATE TABLE [PERSONAS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[CEDULA] NVARCHAR(100) NOT NULL UNIQUE,
	[NOMBRE] NVARCHAR(100) NOT NULL,
	CONSTRAINT [PK_PERSONAS] PRIMARY KEY CLUSTERED ([ID]),

)
GO

CREATE TABLE [USUARIOS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[USUARIO] NVARCHAR(100) NOT NULL UNIQUE,
	[CONTRASE�A] NVARCHAR(100) NOT NULL,
	[PERSONA] INT NOT NULL,
	CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_USUARIOS_PERSONAS] FOREIGN KEY ([PERSONA]) REFERENCES [PERSONAS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [PRESTAMOS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[NUMERO] NVARCHAR(100) NOT NULL UNIQUE,
	[FECHA] DATETIME NOT NULL,
	[USUARIO] INT NOT NULL,
	CONSTRAINT [PK_PRESTAMOS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_PRESTAMOS_USUARIOS] FOREIGN KEY ([USUARIO]) REFERENCES [USUARIOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [NOTAS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[DESCRIPCION] NVARCHAR(500) NOT NULL,
	[PRESTAMO] INT NOT NULL,
	CONSTRAINT [PK_NOTAS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_NOTAS_PRESTAMOS] FOREIGN KEY ([PRESTAMO]) REFERENCES [PRESTAMOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [ESTADOS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[NOMBRE] NVARCHAR(50) NOT NULL UNIQUE,
	CONSTRAINT [PK_ESTADOS] PRIMARY KEY CLUSTERED ([ID])
)
GO

CREATE TABLE [LIBROS]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[NOMBRE] NVARCHAR(100) NOT NULL UNIQUE,
	[AUTOR] NVARCHAR(100) NOT NULL,
	[ESTADO] INT NOT NULL,
	CONSTRAINT [PK_LIBROS] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_LIBROS_ESTADOS] FOREIGN KEY ([ESTADO]) REFERENCES [ESTADOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

CREATE TABLE [DETALLES]
(
	[ID] INT NOT NULL IDENTITY (1, 1),
	[PRESTAMO] INT NOT NULL,
	[LIBRO] INT NOT NULL,
	CONSTRAINT [PK_DETALLES] PRIMARY KEY CLUSTERED ([ID]),
	CONSTRAINT [FK_DETALLES_PRESTAMOS] FOREIGN KEY ([PRESTAMO]) REFERENCES [PRESTAMOS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT [FK_DETALLES_LIBROS] FOREIGN KEY ([LIBRO]) REFERENCES [LIBROS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
)
GO

--------------------------------INSERTAR DATOS

INSERT INTO PERSONAS (CEDULA, NOMBRE) VALUES 
('1234567890', 'Juan P�rez'),
('0987654321', 'Mar�a Garc�a'),
('1122334455', 'Carlos L�pez'),
('5566778899', 'Ana Mart�nez'),
('6677889900', 'Luis Rodr�guez'),
('7788990011', 'Patricia Ram�rez'),
('8899001122', 'Pedro Fern�ndez'),
('9900112233', 'Sof�a Morales'),
('1010101010', 'Miguel G�mez'),
('2020202020', 'Claudia Herrera');
GO

INSERT INTO USUARIOS (USUARIO, CONTRASE�A, PERSONA) VALUES 
('juanperez', 'password1', 1),
('mariagarcia', 'password2', 2),
('carloslopez', 'password3', 3),
('anamartinez', 'password4', 4),
('luisrodriguez', 'password5', 5),
('patriciaramirez', 'password6', 6),
('pedrofernandez', 'password7', 7),
('sofiamorales', 'password8', 8),
('miguelgomez', 'password9', 9),
('claudiaherrera', 'password10', 10);
GO

INSERT INTO PRESTAMOS (NUMERO, FECHA, USUARIO) VALUES 
('PREST001', '2023-01-01', 1),
('PREST002', '2023-02-01', 2),
('PREST003', '2023-03-01', 3),
('PREST004', '2023-04-01', 4),
('PREST005', '2023-05-01', 5),
('PREST006', '2023-06-01', 6),
('PREST007', '2023-07-01', 7),
('PREST008', '2023-08-01', 8),
('PREST009', '2023-09-01', 9),
('PREST010', '2023-10-01', 10);
GO

INSERT INTO NOTAS (DESCRIPCION, PRESTAMO) VALUES 
('El usuario ha devuelto el libro sin da�os.', 1),
('El libro presenta marcas de uso en la portada.', 2),
('El usuario reporta haber extraviado el libro.', 3),
('El pr�stamo ha sido renovado por una semana m�s.', 4),
('El libro est� reservado para otro usuario.', 5),
('El libro fue devuelto fuera del plazo acordado.', 6),
('El usuario ha solicitado una extensi�n del pr�stamo.', 7),
('El libro ha sido devuelto en perfectas condiciones.', 8),
('El libro no fue devuelto, se considera extraviado.', 9),
('El usuario ha devuelto el libro y ha solicitado otro.', 10);
GO

INSERT INTO ESTADOS (NOMBRE) VALUES 
('Disponible'),
('Prestado'),
('Extraviado'),
('Reservado'),
('No disponible')
GO

INSERT INTO LIBROS (NOMBRE, AUTOR, ESTADO) VALUES 
('Cien a�os de soledad', 'Gabriel Garc�a M�rquez', 1), 
('1984', 'George Orwell', 2), 
('Don Quijote de la Mancha', 'Miguel de Cervantes', 3), 
('Orgullo y prejuicio', 'Jane Austen', 4), 
('El se�or de los anillos', 'J.R.R. Tolkien', 5), 
('Crimen y castigo', 'Fi�dor Dostoyevski', 1), 
('Matar a un ruise�or', 'Harper Lee', 2), 
('La metamorfosis', 'Franz Kafka', 3), 
('El gran Gatsby', 'F. Scott Fitzgerald', 4), 
('Los miserables', 'Victor Hugo', 5);
GO

INSERT INTO DETALLES (PRESTAMO, LIBRO) VALUES 
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(6, 6),
(7, 7),
(8, 8),
(9, 9),
(10, 10);
GO
