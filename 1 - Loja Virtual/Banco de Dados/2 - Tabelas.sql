USE LojaVirtual_Dev
BEGIN TRY
BEGIN TRAN
DECLARE @ApenasTeste BIT = 0


--===================================================================
--===================================================================

IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'seguranca' AND TABLE_NAME = 'Usuario')
BEGIN
	CREATE TABLE seguranca.Usuario(
		Codigo		INT PRIMARY KEY IDENTITY,
		Nome		NVARCHAR(255) NOT NULL,
		Email		VARCHAR(255) NOT NULL,
		HashSenha	VARBINARY(32) NOT NULL,
		SaltSenha	VARBINARY(16) NOT NULL,
		Situacao	BIT NOT NULL DEFAULT 1,
		Criacao		DATETIME NOT NULL DEFAULT GETDATE()
	)
	PRINT 'Tabela seguranca.Usuario criada!';
END;


IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'cadastro' AND TABLE_NAME = 'Produto')
BEGIN
	CREATE TABLE cadastro.Produto(
		Codigo		INT PRIMARY KEY IDENTITY,
		Nome		NVARCHAR(255) NOT NULL,
		Preco		DECIMAL (10,2) NOT NULL,
		Ativo		BIT NOT NULL DEFAULT 1
	)
	PRINT 'Tabela cadastro.Produto criada!';
END;

--====================================================================
--====================================================================

IF @ApenasTeste = 1 BEGIN ROLLBACK; print 'Rollback'; END ELSE BEGIN COMMIT; print 'Commit' END
END TRY
BEGIN CATCH
--SELECT * FROM geral.CapturarErro()
ROLLBACK
END CATCH

