# Validação de Senha
Projeto desenvolvido para cumprir um desafio técnico.

# Problema
Construa uma aplicação que exponha uma api web que valide se uma senha é válida.

Input: Uma senha (string).
Output: Um boolean indicando se a senha é válida.

Considere uma senha sendo válida quando a mesma possuir as seguintes definições:

- Nove ou mais caracteres
- Ao menos 1 dígito
- Ao menos 1 letra minúscula
- Ao menos 1 letra maiúscula
- Ao menos 1 caractere especial
Considere como especial os seguintes caracteres: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto

# Solução

Para este projeto utilizei .NET 6. Seguindo o modelo de API Web disponibilizado com a interface do swagger. Para deixar o código mais limpo, utilizei expressões lambda. Por conter somente a propriedade "password", apliquei uma controller.
Separei as regras de validação em três condições de "if", pelo motivo do grau de lógica serem parecidos. O código presente foi realizado em inglês para pratica e aperfeiçoamento do idioma.

Para aplicar as condições solicitadas com a entrada do tipo "Char", utilizei os seguintes métodos:

Ao menos 1 dígito - método utilizado: IsDigit;
Ao menos 1 letra minúscula - método utilizado: IsLower;
Ao menos 1 letra maiúscula - método utilizado: IsUpper;
Ao menos 1 caractere especial - método utilizado: IsLetterOrDigit;

Utilizei o método "IsNullOrEmpty" para verificar se a entrada é nula ou vazia, e a propriedade "Length" para verificar se o tamanho é menor ou igual a nove. 
Para verificar a regra "Não possuir caracteres repetidos dentro do conjunto", utilizei a propriedade "Length" junto com os métodos "Distinct" e "Count" da biblioteca "Linq". Nessa regra precisei pesquisar o método Distinct() que remove todos os elementos duplicados da coleção original, e o método Count() que retorna o número de elementos na coleção. Com isso, encaixei ambos na minha lógica para verificar duplicidade dentro do conjunto.

Para as outras regras foram criadas as variáreis "hasUppercase", "hasLowercase", "hasDigit" e "hasSpecialCharacter", utilizando expressões lambda e métodos da biblioteca "linq", para validar cada variável e no final verifiquei através da condição "if" os seus retornos.

## Instalação e Execução

1. Para executar este projeto, é necessário ter o Visual Studio 2022 e o .NET Core SDK instalado.
2. Clone o repositório em sua máquina. Acesse o diretório do projeto e abra o arquivo ValidacaoSenha.sln.
3. Execute através do Visual Studio.
3. O projeto estará disponível em http://localhost:5000.

## Contribuição

1. Fork o projeto.
2. Crie uma nova branch com a funcionalidade ou correção que deseja implementar.
3. Faça o commit das alterações.
4. Envie a branch para o repositório remoto.
5. Crie um novo Pull Request.
