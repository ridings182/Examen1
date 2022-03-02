CREATE PROCEDURE [dbo].[ParametroObtener]
	@IdParametro INT = NULL

AS

BEGIN
	SET NOCOUNT ON

	SELECT
			 IdParametro
			,Codigo
			,Descripcion
			,Valor
			,Estado


	FROM dbo.Parametro

	WHERE
			(@IdParametro IS NULL OR IdParametro=@IdParametro)


END
