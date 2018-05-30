
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 12/04/2018 1:21:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/04/2018 1:21:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/04/2018 1:21:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/04/2018 1:21:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/04/2018 1:21:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/04/2018 1:21:57 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201803110555421_InitialCreate', N'LKACSOFT.UI.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5C5B6FE3B6127E2F70FE83A0A7738AD4CAA5BBD813D85BA44E7C4ED0DCB04E16E76D414BB423AC44A912954D50F497F5A13FA97FE10C25EAC68B2EB6623BC5028B881C7E331C0EC9E170E8BFFEF873FCD3B3EF194F388ADD804CCCA3D1A1696062078E4B561333A1CB1F3E983F7DFCC777E30BC77F363EE774278C0E5A9278623E521A9E5A566C3F621FC523DFB5A3200E96746407BE859CC03A3E3CFCB775746461803001CB30C69F12425D1FA71FF0390D888D439A20EF3A70B017F372A899A7A8C60DF2711C221B4FCCAB5FCEA6F3DBD9FDE8E17294519BC699E72290648EBDA5692042028A28C879FA10E3398D02B29A875080BCFB971003DD127931E6F29F96E45DBB7278CCBA62950D73283B8969E0F7043C3AE1BAB1C4E66B69D82C7407DABB002DD317D6EB548313F3D2C169D1A7C00305880C4FA75EC48827E675C1E22C0E6F301DE50D4719E42C02B86F41F47554453C303AB73B286CE97874C8FE1D18D3C4A349842704273442DE8171972C3CD7FE05BFDC075F31999C1C2D96271FDEBD47CEC9FB1FF1C9BB6A4FA1AF40572B80A2BB28087104B2E165D17FD3B0EAED2CB161D1ACD226D30AD8124C0BD3B846CF5798ACE8234C98E30FA631739FB1939770E37A202ECC226844A3043E6F12CF430B0F17F556234FF67F03D7E377EF07E17A839EDC553AF4027F983811CCAB4FD84B6BE34737CCA6576DBCBF70B25914F8ECBB6E5F59ED9779904436EB4CA025B947D10AD3BA7463AB34DE4E26CDA08637EB1C75FF4D9B492A9BB7929475689D9990B3D8F66CC8E57D5DBE9D2DEE2C0C61F052D3621A69323879B31A09AD0F8C0A4D693A475D4D874097FECE2BE1858F5C6F80A5B00317F042966EE4E3A2973F07607888F496F90EC531AC04CE7F51FCD8203AFC3980E8736C271118E89C223F7C756E778F01C13789BF6076BF3D5E830DCDFDB760866C1A441784B5DA18EF2AB0BF0609BD20CE39A2F881DA3920FBBC77FDEE0083887366DB388E6760CCD89906E064E78097849E1CF786630BD4AE5D91A9875C5FED8B084BE9979CB4F447D414924FA22153F9254DA25E052B9774133527D58B9A51B48ACAC9FA8ACAC0BA49CA29F582A604AD72665483797AE9080DEFEAA5B0FBEFEB6DB679EBD6828A1AE7B042E2FF60822358C69C3B44298E4839025DD68D5D380BE9F031A6AFBE37A59C3E232F199AD55AB3215D04869F0D29ECFECF86544C287E721DE695743800E5C400DF895E7DB66A9F738264DB9E0EB56E6E9BF976D600DD74398BE3C076D359A0087DF1C0455D7EF0E18CF62846D61B3112021D034377D9960725D0375334AA5B728E3D4CB1716667A1C1298A6DE4C86A840E393D04CB775485606544A42EDCF7124FB0741CB146881D826298A92EA1F2B47089ED86C86BD592D0B2E316C6FA5EF0106BCE71880963D8AA892ECCD501102640C1471894360D8DAD8AC5351BA2C66BD58D799B0B5B8EBB1497D88A4DB6F8CE1ABBE4FEDBAB1866B3C6B6609CCD2AE922803698B70B03E56795AE06201E5CF6CD40851393C640B94BB51503AD6B6C07065A57C99B33D0EC88DA75FC85F3EABE9967FDA0BCFD6DBD515D3BB0CD9A3EF6CC3433DF13DA50688123D93CCF17AC123F53C5E10CE4E4E7B398BBBAA28930F039A6F5904DE9EF2AFD50AB194434A226C0D2D05A40F935A004244DA81EC2E5B1BC46E9B817D103368FBB35C2F2B55F80ADD8808C5DBD0EAD10EA2F4D45E3EC74FA287A56588364E49D0E0B151C8541888B57BDE31D94A28BCBCA8AE9E20BF7F1862B1DE383D1A0A016CF55A3A4BC33836B2937CD762DA91CB23E2ED9465A12DC278D96F2CE0CAE256EA3ED4A5238053DDC828D5454DFC2079A6C79A4A3D86D8ABAB1956549F182B1A549A71A5FA33074C9AA925EC54B8C79965B35FD61DE3FE9C8CF302C3B56E41E15D2169C6810A115166A8135483A73A3989E238A1688C579A68E2F9129F756CDF29FB3AC6E9FF220E6FB404ECDFEE6D13BF9F2BEB6D7CACE08C798410F7DE6D1A46174C5F8AB9B1B2CDD0D79285244EEA78197F844EF60E95B67F777D5F659898C30B604F925074AD296E4E6D655DF6960E44931D02015FECBFA03A587D0A93BF73EAB0AD779A47A943C405545D105AD7636703A47A6D760893E62FFB16A45789D79C51353AA00BCA8274625B74102ABD47547ADA79F5431EB35DD11851C932AA450D543CA6A26494DC86AC55A781A8DAA29BA73907347AAE8726D7764451649155A51BD06B64266B1AE3BAA22D1A40AACA8EE8E5D669D888BE81EEF5CDA93CBDA5B5776B8DD6CEFD260BCCE8A38CCD657B9C3AF02558A7B62F15B7A098C97EFA535694F786B5B5316D3D8CC9A3418FA95A776FB5D5F781AAFECF598B52BEDDAE2DE74A5AFC7EB67B3AF6A19D2014F2429B817073DE14037E687ABF64734D2692B23318D5C8DB0B1BFC414FB2346309AFFEA4D3D17B3653C27B846C45DE29866691CE6F1E1D1B1F00E677FDEC45871EC788AC3A9EE614C7DCCB69091459E50643FA248CE8FD8E0DD48092A859E2F89839F27E66F69ABD3348AC1FE4A8B0F8CCBF881B8BF2650711F25D8F85DCEF71C268FBEF990B5A7AF1EBA6BF5F27F5FB2A607C66D0433E6D4381474B9CE08D7DF42F492266BBA81346BBF9078BB13AAF6FC40892A4C88F55F1B2C5C3AC84B835CCA7FFAE8F95F7D4553BE26D80851F1626028BC4154A87B11B00E96F63580039F347D0DD0AFB3EAD701EB88A67D19E092FE60E2BB80EECB50DE72875B8DE24CB48D2529D5736B5EF5464996BBDE9BA4F4EB8D26BA9C62DD036E8334EA352CE38D65200FB63B2A128C07C3DEA569BF7A56F1BE241297291EBBCD1FDE66CA70C3B5D0DF2A53780F72DB14B93ABBCF07DEB6ADE9E2B87B9E54D92FEB77CF8C8D6770ED3EB777DBC6A60BF3EEB9B1F5CAE0DD335BDBD5FEB9634BEBBC85EE3C1F574E2DD2DCC7A862C16DF9B659E01C4EF88B008C20F328B36792EA04AFA6E4D4168625899EA93EB34C642C4D1C89AF44D1CCB65F5FF986DFD8594ED3CC56938FD9C49BAFFF8DBC394D336F4D96E32E3285957986AAECED9675AC2909EA2D6506D77AD29288DEE6B3365EAEBFA544E04194529B3D9A3BE2B793F73B884A869C3A3DF27CE5EB5ED83B2BBFAC08FB77ECAE4A08F63B8B04DBB55DB3A0B924CB20DFBC058972122142738D2972604B3D8BA8BB4436856A16634EDF79A7713B76D3B1C0CE25B94D689850E832F6175E2DE0C59C8026FE6932735DE6F16D98FE64C9105D00315D169BBF253F27AEE71472CF1431210D04F32E7844978D256591DDD54B817413908E405C7D8553748FFDD003B0F896CCD1135E473630BF2BBC42F64B1901D481B40F445DEDE37317AD22E4C71CA36C0F9F60C38EFFFCF1FFCF9177CD60540000, N'6.1.3-40302')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'bienhynh96@gmail.com', 0, N'AJFOALBgUvy6ooXZw+/hDYK6U3QrNG6iTd0ZfCj1F3LkOY0GzPVUASu2ogm3BOKCXg==', N'96b01479-45e3-456e-8abc-12edca9840b2', NULL, 0, 0, NULL, 1, 0, N'bienhynh96@gmail.com')
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12/04/2018 1:21:58 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 12/04/2018 1:21:58 CH ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 12/04/2018 1:21:58 CH ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 12/04/2018 1:21:58 CH ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 12/04/2018 1:21:58 CH ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12/04/2018 1:21:58 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [aspnet-LKACSOFT.UI-20180311124855] SET  READ_WRITE 
GO
