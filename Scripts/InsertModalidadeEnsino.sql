USE [CatalogoCurso]
GO

INSERT INTO [dbo].[ModalidadeEnsino]
           ([Id]
           ,[Descricao]
           ,[DataCadastro]
           ,[Ativo])
     VALUES
           ('3A8D1E52-2F17-4BF7-B7DE-9AF616F4185E'
           ,'Presencial'
           ,GETDATE()
           ,1),

          ('68E2C59C-9B52-4C71-998B-B72BCDC9264E'
           ,'EAD'
           ,GETDATE()
           ,1)
GO


