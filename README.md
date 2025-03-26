# Cálculo de IMC (Índice de Massa Corporal)

Este projeto em C# implementa um cálculo simples do IMC (Índice de Massa Corporal) em uma aplicação Windows Forms. O programa recebe o peso e a altura do usuário e calcula o IMC, classificando-o em diferentes categorias com base nos valores calculados.

## Funcionalidades

### 1. **Cálculo do IMC**
   O programa recebe dois inputs do usuário: **peso** e **altura**. Após inserir os dados, o usuário pode clicar no botão **Calcular** para calcular o IMC. O cálculo é feito pela fórmula:

   \[
   IMC = \frac{Peso}{Altura^2}
   \]

   O resultado do IMC é exibido no **label de resultado**.

### 2. **Classificação do IMC**
   O IMC calculado é classificado em diferentes categorias, conforme a tabela abaixo:

   - **IMC > 40**: Obeso(a) Grau III (Mórbida)
   - **IMC ≥ 35**: Obeso(a) Grau III (Severa)
   - **IMC ≥ 30**: Obeso(a) Grau II (Severa)
   - **IMC ≥ 25**: Acima do Peso Ideal - Sobrepeso
   - **IMC ≥ 18,5**: Saudável - Peso Ideal (Normal)
   - **IMC ≥ 17**: Abaixo do Peso (Magreza leve)
   - **IMC ≥ 16**: Abaixo do Peso (Magreza Moderada)
   - **IMC < 16**: Magreza Grave

   O resultado da classificação é exibido em um **label de categoria**.

### 3. **Limpeza dos Campos**
   O botão **Limpar** limpa todos os campos de entrada, o resultado e a categoria, preparando o formulário para um novo cálculo.

### 4. **Fechar a Aplicação**
   O botão **Fechar** encerra a aplicação.

## Estrutura do Código

A aplicação é composta pela classe `Form1`, que controla as funcionalidades de cálculo do IMC, com os seguintes métodos principais:

- **btResultado_Click**: Realiza o cálculo do IMC e exibe o resultado e a classificação.
- **button1_Click**: Limpa os campos de entrada e as saídas.
- **button2_Click**: Encerra a aplicação.
- **txPeso_TextChanged**: Método vazio, mas presente para manipulação de eventos no campo de peso.
- **lbCategoria_Click**: Método vazio, mas presente para manipulação de eventos no campo de categoria.

## Dependências

- **System.Windows.Forms**: Para a interface gráfica com o usuário.
- **System.Math**: Para realizar o cálculo do IMC, utilizando a função `Math.Pow()`.

## Instruções de Uso

1. **Inserir Peso e Altura**: Insira o peso (em kg) e a altura (em metros) nos campos correspondentes.
2. **Calcular IMC**: Clique no botão **Calcular** para ver o valor do IMC e a classificação.
3. **Limpar Campos**: Clique no botão **Limpar** para limpar todos os campos e resultados.
4. **Fechar Aplicação**: Clique no botão **Fechar** para encerrar a aplicação.

## Considerações Finais

Este é um simples aplicativo para calcular o IMC e fornecer uma classificação baseada nos valores obtidos. Ele pode ser expandido para incluir mais funcionalidades, como salvar resultados ou comparar múltiplos cálculos.
