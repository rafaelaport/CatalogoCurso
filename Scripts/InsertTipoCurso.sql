USE [CatalogoCurso]
GO

INSERT INTO [dbo].[TipoCurso]
           ([Id]
           ,[Descricao]
           ,[DataCadastro]
           ,[Ativo])
     VALUES
           ('195c78ef-cf91-4ce4-b414-5968d2c4d686'
           ,'Aprendizagem Profissional de Qualificação'
           ,GETDATE()
           ,1)
GO


