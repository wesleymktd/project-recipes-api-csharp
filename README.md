## 🧐 Sobre

<p align="left"> 
O projeto Recipes api se trata de uma API totalmente funcional onde deve retornar todas as receitas disponíveis, adicionar, remover e atualizar as mesmas. Essa API deve responder aos seguintes endpoints
  
- GET `/recipe` <br/>
Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http 200
```bash
[
    {
	    "name": "Bolo de cenoura",
	    "recipeType": 1,
    "preparationTime": 0.4,
	    "ingredients": [
		  "1/2 xícara (chá) de óleo", "..."
    ],
    "directions": "Em um liquidificador, ...",
    "rating": 10
    },

  /*...*/
]

```  
-  GET `/recipe/:name` <br/>
Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http 200
```bash
  {
	  "name": "Bolo de cenoura",
	  "recipeType": 1,
  "preparationTime": 0.4,
	  "ingredients": [
    "1/2 xícara (chá) de óleo", "..."
  ],
  "directions": "Em um liquidificador, ...",
  "rating": 10
  },

```  
- POST `/recipe`
O corpo da requisição deverá seguir o formato abaixo:
```json
{
  "Name": "Mousse de maracuja",
  "RecipeType": 0,
  "PreparationTime": "0.2",
  "Ingredients": [
    "1 lata de leite condensado",
  ],
  "Directions": "Em um liquidificador, ...",
  "Rating": "9"
}
```
- PUT `/recipe`
```json
"Name": "Mousse de maracuja",
	  "RecipeType": 0,
	  "PreparationTime": "0.2",
	  "Ingredients": [
  		"1 lata de leite condensado",
	  ],
	  "Directions": "Em um liquidificador, ...",
	  "Rating": "9"
```
- DEL `/recipe/:name`
  - O endpoint irá buscar apenas uma receita consultando pelo `name` da receita
  - O corpo da requisição é vazio.
- GET `/user/:email`
- POST `/user`
 ```json
  {
  	"email": "pessoa.nova@betrybe.com",
  	"name": "Pessoa Nova",
  	"password": "senhaDaPessoaNova"
  }
  ```
- PUT `/user/:email`
 - O corpo da requisição deverá seguir o formato abaixo:

  ```json
  {
  	"email": "pessoa@betrybe.com",
  	"name": "Pessoa Nova",
  	"password": "senhaDaPessoaNova"
  }
  ```
- DEL `/user/:email`
- POST `/comment`
  - O corpo da requisição deverá seguir o formato abaixo:
  ```json
  {
  	"Email": "pessoa@betrybe.com",
  	"RecipeName": "Coxinha",
  	"CommentText": "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e funcionou."
  } 
  ```
- GET `/comment/:recipeName`
  - Se a requisição for feita com sucesso o resultado retornado deverá ser conforme exibido abaixo, com um status http `200`:
    ```json
	  [
	    {
		    "email": "pessoa@betrybe.com",
		    "recipeName": "Coxinha",
		    "commentText": "Fiz a receita de Coxinha na minha casa. Fiz o passo a passo e saiu certinho."
	    },

      /* ... */
    ]
    ```  

## ⚒ Instalando <a name = "installing"></a>

```bash
# Clone o projeto
$ git clone git@github.com:wesleymktd/project-recipes-api-csharp.git
# Acesse
$ cd ./project-recipes-api-csharp/src
# Instale as dependencias
$ dotnet restore
# Inicie o projeto
$ dotnet run

```

## Principais tecnologias utilizadas:
- C#;
- ASP.NET
