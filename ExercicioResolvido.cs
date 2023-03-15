// Definição da classe Animal
public class Animal
{
    public string Nome { get; set; }
}

// Definição da classe Mamifero, que herda da classe Animal
public class Mamifero : Animal
{
}

// Definição da interface AlimentarFilhotes
public interface AlimentarFilhotes
{
    int QuantidadeComida();
}

// Definição da classe Tigre, que herda da classe Mamifero e implementa a interface AlimentarFilhotes
public class Tigre : Mamifero, AlimentarFilhotes
{
    public int QuantidadeComida()
    {
        // Implementação do método QuantidadeComida da interface AlimentarFilhotes para a classe Tigre
        return 10; // Exemplo: quantidade de carne que um tigre pode fornecer para seus filhotes
    }
}
