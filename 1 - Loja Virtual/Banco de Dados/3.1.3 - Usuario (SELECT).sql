CREATE OR ALTER PROCEDURE seguranca.BuscarUsuario (
	@Codigo INT = NULL,
	@Email VARCHAR(255) = NULL
)

AS BEGIN
	SET NOCOUNT ON;

	IF (@Codigo IS NULL)
		IF (@Email IS NULL)
		BEGIN
			SELECT usu.Codigo, usu.Email, usu.HashSenha, usu.SaltSenha
				FROM seguranca.Usuario usu 
		END;
		ELSE
		BEGIN
			SELECT usu.Codigo, usu.Email, usu.HashSenha, usu.SaltSenha
				FROM seguranca.Usuario usu
					WHERE usu.Email = @Email
		END;
	ELSE
		SELECT usu.Codigo, usu.Email, usu.HashSenha, usu.SaltSenha
			FROM seguranca.Usuario usu
				WHERE usu.Codigo = @Codigo
	END;


	

