Drop Database If Exists controle_de_condominio;

Create Database If Not Exists controle_de_condominio;

Use controle_de_condominio;

Create Table condominio (
			 id_condominio   Int 		   Not Null Auto_Increment,
			 nome		     Varchar(90)   Not Null,
			 cep		     Char(9),
			 codigo_postal   Varchar(20),
			 numero		     Int		    Not Null,
			 cidade		     Varchar(25) 	Not Null,
			 estado		     Char(2),
			 provincia	     Varchar(20),
			 pais		     Varchar(20),
Constraint   condominio      Primary Key(id_condominio));

Create Table predio (
			 id_predio	     Int		    Not Null Auto_Increment,
             nome		     Varchar(90),
             numero		     Int,
             id_condominio   Int		    Not Null,
Constraint   predio		     Primary Key(id_predio),
Foreign Key (id_condominio)  References   condominio (id_condominio));

Create Table morador (
			 id_morador      Int			 Not Null Auto_Increment,
             nome		     Varchar(25)	 Not Null,
             sobrenome	     Varchar(25)	 Not Null,
             cpf			 Char(14),
             rg			     Char(12),
             doc_civil	     Varchar(30),
             sexo		     Varchar(20)	 Not Null,
             cep			 Char(9),
             cod_postal	     Varchar(20),
             rua			 Varchar(80)	 Not Null,
             numero		     Int			 Not Null,
             cidade		     Varchar(20)	 Not Null,
             estado		     Char(2),
             provincia	     Varchar(25),
             celular		 Varchar(20),
             fixo		     Varchar(15),
             email		     Varchar(255) 	 Not Null,
             id_condominio   Int,
             id_predio	     Int,
             foto		     Blob,
Constraint   morador		 Primary Key(id_morador),
Foreign Key (id_condominio)  References condominio (id_condominio),
Foreign Key (id_predio)	     References predio (id_predio)
);

Create Table visitante (
			 id_visitante    Int,
             nome		     Varchar(25)	Not Null,
             sobrenome	     Varchar(25)	Not Null,
             cpf			 Char(14),
             rg			     Char(12),
             doc_civil	     Varchar(25),
             sexo		     Varchar(20)	Not Null,
             foto		     Blob,
             celular		 Varchar(20)	Not Null,
             fixo		     Varchar(15),
			 email		     Varchar(255),
			 id_morador      Int			Not Null,
             id_predio	     Int 			Not Null,
             id_condominio   Int			Not Null,
Constraint   visitante	     Primary Key (id_visitante),
Foreign Key (id_morador)     References morador (id_morador),
Foreign Key (id_predio)	     References predio	 (id_predio),
Foreign Key (id_condominio)  References condominio (id_condominio));

Create Table apartamento (
			 id				 Int,
             numero			 Int,
             id_morador		 Int,
             id_predio		 Int,
             id_condominio	 Int,
Constraint	 apartamento	 Primary Key (id),
Foreign Key  (id_morador)	 References morador (id_morador),
Foreign Key  (id_predio)	 References predio (id_predio),
Foreign Key  (id_condominio) References condominio (id_condominio)
); 

Create Table garagem (
			 id				  Int,
             id_predio		  Int,
             id_condominio	  Int,
Constraint	 garagem		  Primary Key (id),
Foreign Key  (id_predio)	  References predio (id_predio),
Foreign Key	 (id_condominio)  References condominio (id_condominio));

Create Table veiculo (
			 id				  Int,
             id_morador		  Int,
             id_predio		  Int,
             id_condominio	  Int,
Constraint	 veiculo		  Primary Key (id),
Foreign Key  (id_morador) 	  References morador (id_morador),
Foreign Key	 (id_predio)	  References predio  (id_predio),
Foreign Key  (id_condominio)  References condominio (id_condominio));

Create Table prestador_serv (
			 id				  Int,
             nome			  Varchar(45),
             cnpj			  Char(18),
             cpf			  Char(14),
             id_predio		  Int,
             id_condominio	  Int,
Constraint	 prestador_serv	  Primary Key (id),
Foreign Key  (id_predio)	  References predio (id_predio),
Foreign Key  (id_condominio)  References condominio (id_condominio)
);

Create Table sindico ( 
			 id				  Int,
             nome			  Varchar(20),
             sobrenome		  Varchar(60),
             cpf			  Char(14),
             rg				  Char(12),
             doc_civil		  Varchar(20),
             telefone		  Varchar(25),
             email			  Varchar(255),
             foto			  Blob,
             id_predio		  Int,
             id_condominio	  Int,
Constraint   sindico 		  Primary Key (id),
Foreign Key  (id_predio)	  References predio (id_predio),
Foreign Key  (id_condominio)  References condominio (id_condominio));

Create Table login (
			 id				  Int,
             usuario		  Varchar(45),
             senha			  Varchar(90),
             nivel_acesso	  Varchar(90));
             
Create Table recuperacao_senha (
			 email			  Varchar(255),
             celular		  Varchar(20));