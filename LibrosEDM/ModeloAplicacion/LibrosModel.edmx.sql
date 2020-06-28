
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/09/2019 12:50:55
-- Generated from EDMX file: F:\Clases 2019\Ejercios Clase\Video programacion catalogos\PrestamosDeLibros\LibrosEDM\ModeloAplicacion\LibrosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Prestamos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MateriaLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Libros] DROP CONSTRAINT [FK_MateriaLibro];
GO
IF OBJECT_ID(N'[dbo].[FK_IdiomaLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Libros] DROP CONSTRAINT [FK_IdiomaLibro];
GO
IF OBJECT_ID(N'[dbo].[FK_EditorialLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Libros] DROP CONSTRAINT [FK_EditorialLibro];
GO
IF OBJECT_ID(N'[dbo].[FK_LibroDetalleDeAutor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetallesDeAutor] DROP CONSTRAINT [FK_LibroDetalleDeAutor];
GO
IF OBJECT_ID(N'[dbo].[FK_AutorDetalleDeAutor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetallesDeAutor] DROP CONSTRAINT [FK_AutorDetalleDeAutor];
GO
IF OBJECT_ID(N'[dbo].[FK_EstadoDelLibroCopiaDeLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CopiasDeLibro] DROP CONSTRAINT [FK_EstadoDelLibroCopiaDeLibro];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAlquilerDeLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlquileresDeLibro] DROP CONSTRAINT [FK_ClienteAlquilerDeLibro];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoDeClienteCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clientes] DROP CONSTRAINT [FK_TipoDeClienteCliente];
GO
IF OBJECT_ID(N'[dbo].[FK_CopiaDeLibroAlquilerDeLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlquileresDeLibro] DROP CONSTRAINT [FK_CopiaDeLibroAlquilerDeLibro];
GO
IF OBJECT_ID(N'[dbo].[FK_LibroCopiaDeLibro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CopiasDeLibro] DROP CONSTRAINT [FK_LibroCopiaDeLibro];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Materias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Materias];
GO
IF OBJECT_ID(N'[dbo].[Idiomas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Idiomas];
GO
IF OBJECT_ID(N'[dbo].[Editoriales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Editoriales];
GO
IF OBJECT_ID(N'[dbo].[TiposDeCliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TiposDeCliente];
GO
IF OBJECT_ID(N'[dbo].[EstadosDelLibro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadosDelLibro];
GO
IF OBJECT_ID(N'[dbo].[Libros]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Libros];
GO
IF OBJECT_ID(N'[dbo].[Autores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Autores];
GO
IF OBJECT_ID(N'[dbo].[DetallesDeAutor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetallesDeAutor];
GO
IF OBJECT_ID(N'[dbo].[CopiasDeLibro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CopiasDeLibro];
GO
IF OBJECT_ID(N'[dbo].[AlquileresDeLibro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlquileresDeLibro];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Materias'
CREATE TABLE [dbo].[Materias] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDeMateria] char(3)  NOT NULL,
    [DescripcionDeLaMateria] varchar(50)  NOT NULL
);
GO

-- Creating table 'Idiomas'
CREATE TABLE [dbo].[Idiomas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDelIdioma] char(3)  NOT NULL,
    [DescripcionDelIdioma] varchar(50)  NOT NULL
);
GO

-- Creating table 'Editoriales'
CREATE TABLE [dbo].[Editoriales] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDeLaEditorial] char(3)  NOT NULL,
    [DescripcionDeLaEditorial] varchar(50)  NOT NULL
);
GO

-- Creating table 'TiposDeCliente'
CREATE TABLE [dbo].[TiposDeCliente] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoTipoDeCliente] char(3)  NOT NULL,
    [DescripcionTipoDeCliente] varchar(50)  NOT NULL
);
GO

-- Creating table 'EstadosDelLibro'
CREATE TABLE [dbo].[EstadosDelLibro] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoEstadoDelLibro] char(3)  NOT NULL,
    [DescripcionEstadoDelLibro] varchar(50)  NOT NULL
);
GO

-- Creating table 'Libros'
CREATE TABLE [dbo].[Libros] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDelLibro] char(3)  NOT NULL,
    [Titulo] varchar(50)  NOT NULL,
    [MateriaId] int  NOT NULL,
    [IdiomaId] int  NOT NULL,
    [EditorialId] int  NOT NULL,
    [ISBN] char(30)  NOT NULL
);
GO

-- Creating table 'Autores'
CREATE TABLE [dbo].[Autores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDelAutor] char(10)  NOT NULL,
    [NombresDelAutor] varchar(30)  NOT NULL,
    [ApellidosDelAutor] varchar(30)  NOT NULL
);
GO

-- Creating table 'DetallesDeAutor'
CREATE TABLE [dbo].[DetallesDeAutor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LibroId] int  NOT NULL,
    [AutorId] int  NOT NULL
);
GO

-- Creating table 'CopiasDeLibro'
CREATE TABLE [dbo].[CopiasDeLibro] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NumeroDeCopia] int  NOT NULL,
    [EstadoDelLibroId] int  NOT NULL,
    [LibroId] int  NOT NULL
);
GO

-- Creating table 'AlquileresDeLibro'
CREATE TABLE [dbo].[AlquileresDeLibro] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDeAlquiler] varchar(3)  NOT NULL,
    [FechaDelAlquiler] datetime  NOT NULL,
    [FechaEstimadaDevolucion] datetime  NOT NULL,
    [FechaRealDevolucion] datetime  NOT NULL,
    [ClienteId] int  NOT NULL,
    [CopiaDeLibroId] int  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CodigoDelCliente] char(3)  NOT NULL,
    [NombresDelCliente] varchar(50)  NOT NULL,
    [ApellidosDelCliente] varchar(50)  NOT NULL,
    [TipoDeClienteId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Materias'
ALTER TABLE [dbo].[Materias]
ADD CONSTRAINT [PK_Materias]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Idiomas'
ALTER TABLE [dbo].[Idiomas]
ADD CONSTRAINT [PK_Idiomas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Editoriales'
ALTER TABLE [dbo].[Editoriales]
ADD CONSTRAINT [PK_Editoriales]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TiposDeCliente'
ALTER TABLE [dbo].[TiposDeCliente]
ADD CONSTRAINT [PK_TiposDeCliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EstadosDelLibro'
ALTER TABLE [dbo].[EstadosDelLibro]
ADD CONSTRAINT [PK_EstadosDelLibro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [PK_Libros]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Autores'
ALTER TABLE [dbo].[Autores]
ADD CONSTRAINT [PK_Autores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DetallesDeAutor'
ALTER TABLE [dbo].[DetallesDeAutor]
ADD CONSTRAINT [PK_DetallesDeAutor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CopiasDeLibro'
ALTER TABLE [dbo].[CopiasDeLibro]
ADD CONSTRAINT [PK_CopiasDeLibro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AlquileresDeLibro'
ALTER TABLE [dbo].[AlquileresDeLibro]
ADD CONSTRAINT [PK_AlquileresDeLibro]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MateriaId] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [FK_MateriaLibro]
    FOREIGN KEY ([MateriaId])
    REFERENCES [dbo].[Materias]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MateriaLibro'
CREATE INDEX [IX_FK_MateriaLibro]
ON [dbo].[Libros]
    ([MateriaId]);
GO

-- Creating foreign key on [IdiomaId] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [FK_IdiomaLibro]
    FOREIGN KEY ([IdiomaId])
    REFERENCES [dbo].[Idiomas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_IdiomaLibro'
CREATE INDEX [IX_FK_IdiomaLibro]
ON [dbo].[Libros]
    ([IdiomaId]);
GO

-- Creating foreign key on [EditorialId] in table 'Libros'
ALTER TABLE [dbo].[Libros]
ADD CONSTRAINT [FK_EditorialLibro]
    FOREIGN KEY ([EditorialId])
    REFERENCES [dbo].[Editoriales]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EditorialLibro'
CREATE INDEX [IX_FK_EditorialLibro]
ON [dbo].[Libros]
    ([EditorialId]);
GO

-- Creating foreign key on [LibroId] in table 'DetallesDeAutor'
ALTER TABLE [dbo].[DetallesDeAutor]
ADD CONSTRAINT [FK_LibroDetalleDeAutor]
    FOREIGN KEY ([LibroId])
    REFERENCES [dbo].[Libros]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LibroDetalleDeAutor'
CREATE INDEX [IX_FK_LibroDetalleDeAutor]
ON [dbo].[DetallesDeAutor]
    ([LibroId]);
GO

-- Creating foreign key on [AutorId] in table 'DetallesDeAutor'
ALTER TABLE [dbo].[DetallesDeAutor]
ADD CONSTRAINT [FK_AutorDetalleDeAutor]
    FOREIGN KEY ([AutorId])
    REFERENCES [dbo].[Autores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AutorDetalleDeAutor'
CREATE INDEX [IX_FK_AutorDetalleDeAutor]
ON [dbo].[DetallesDeAutor]
    ([AutorId]);
GO

-- Creating foreign key on [EstadoDelLibroId] in table 'CopiasDeLibro'
ALTER TABLE [dbo].[CopiasDeLibro]
ADD CONSTRAINT [FK_EstadoDelLibroCopiaDeLibro]
    FOREIGN KEY ([EstadoDelLibroId])
    REFERENCES [dbo].[EstadosDelLibro]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoDelLibroCopiaDeLibro'
CREATE INDEX [IX_FK_EstadoDelLibroCopiaDeLibro]
ON [dbo].[CopiasDeLibro]
    ([EstadoDelLibroId]);
GO

-- Creating foreign key on [ClienteId] in table 'AlquileresDeLibro'
ALTER TABLE [dbo].[AlquileresDeLibro]
ADD CONSTRAINT [FK_ClienteAlquilerDeLibro]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAlquilerDeLibro'
CREATE INDEX [IX_FK_ClienteAlquilerDeLibro]
ON [dbo].[AlquileresDeLibro]
    ([ClienteId]);
GO

-- Creating foreign key on [TipoDeClienteId] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [FK_TipoDeClienteCliente]
    FOREIGN KEY ([TipoDeClienteId])
    REFERENCES [dbo].[TiposDeCliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoDeClienteCliente'
CREATE INDEX [IX_FK_TipoDeClienteCliente]
ON [dbo].[Clientes]
    ([TipoDeClienteId]);
GO

-- Creating foreign key on [CopiaDeLibroId] in table 'AlquileresDeLibro'
ALTER TABLE [dbo].[AlquileresDeLibro]
ADD CONSTRAINT [FK_CopiaDeLibroAlquilerDeLibro]
    FOREIGN KEY ([CopiaDeLibroId])
    REFERENCES [dbo].[CopiasDeLibro]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CopiaDeLibroAlquilerDeLibro'
CREATE INDEX [IX_FK_CopiaDeLibroAlquilerDeLibro]
ON [dbo].[AlquileresDeLibro]
    ([CopiaDeLibroId]);
GO

-- Creating foreign key on [LibroId] in table 'CopiasDeLibro'
ALTER TABLE [dbo].[CopiasDeLibro]
ADD CONSTRAINT [FK_LibroCopiaDeLibro]
    FOREIGN KEY ([LibroId])
    REFERENCES [dbo].[Libros]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LibroCopiaDeLibro'
CREATE INDEX [IX_FK_LibroCopiaDeLibro]
ON [dbo].[CopiasDeLibro]
    ([LibroId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------