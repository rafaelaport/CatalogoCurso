USE [CatalogoCurso]
GO

INSERT INTO [dbo].[Segmento]
           ([Id]
           ,[Descricao]
           ,[DataCadastro]
           ,[Ativo])
     VALUES
           ('7d91c00f-98c1-46b8-9dc3-9e8d7d6200b5'
           ,'Formação Inicial e Continuada'
           ,GETDATE()
           ,1)
GO


