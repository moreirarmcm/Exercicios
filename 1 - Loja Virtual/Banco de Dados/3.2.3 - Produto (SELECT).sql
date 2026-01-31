CREATE OR ALTER PROCEDURE cadastro.BuscarProduto (
	@Codigo		INT = NULL,
	@Nome		NVARCHAR(255) = NULL
)

AS BEGIN
	SET NOCOUNT ON;

	IF (@Codigo IS NULL)
		IF (@Nome IS NULL)
		BEGIN
			SELECT *
				FROM cadastro.Produto pro 
		END;
		ELSE
		BEGIN
			SELECT pro.Codigo, pro.Nome, pro.Preco
				FROM cadastro.Produto pro 
					WHERE pro.Nome = @Nome
						AND Ativo = 1
		END;
	ELSE
		SELECT pro.Codigo, pro.Nome, pro.Preco
				FROM cadastro.Produto pro 
					WHERE pro.Codigo = @Codigo
						AND Ativo = 1
	END;


	

