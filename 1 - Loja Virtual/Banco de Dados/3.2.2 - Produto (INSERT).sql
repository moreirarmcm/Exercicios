CREATE OR ALTER PROCEDURE cadastro.InserirProduto (
	@Nome			NVARCHAR(255),
	@Preco			DECIMAL (10,2)
)
AS BEGIN

	SET NOCOUNT ON;

	INSERT INTO cadastro.Produto
			(Nome,	Preco)
	VALUES	(@Nome, @Preco)

	SELECT SCOPE_IDENTITY() AS CodigoProduto;
END
