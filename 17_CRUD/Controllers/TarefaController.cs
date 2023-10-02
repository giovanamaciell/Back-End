using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;


//Craindo a classse TarefaController e herdando seus métodos de Controller
public class TarefaController : Controller
{

    //Criando um objeto _tarefas que  armazenará uma lista de tarefas
    private static List<Tarefa> _tarefas = new List<Tarefa>();

    public IActionResult Index()
    {
        return View(_tarefas);
    }

    public IActionResult Adicionar()
    {
        return View();
    }

    [HttpPost]

    public IActionResult Adicionar(Tarefa novaTarefa)
    {

        //Verificando o total da lista e somando mais 1 para criar o ID
        novaTarefa.Id = _tarefas.Count + 1;
        //Adicionando minha nova tarefa à minha lista
        _tarefas.Add(novaTarefa);
        //Redirecionando para a página principal lista de tarefas
        return RedirectToAction("Index");
    }

    public IActionResult Editar(int Id)
    {
        //Estou buscando na minha lista a tarefa que deseja alterar
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        //Verificando se ela existe
        if (novaTarefa == null)
            return NotFound();

        //Enviando para a View a tarefa que queremos alterar
        return View(novaTarefa);

    }

    [HttpPost]

    public IActionResult Editar(Tarefa tarefaEditando)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == tarefaEditando.Id);
        if (tarefaEncontrada == null)
            return NotFound();

       tarefaEncontrada.Descricao = tarefaEditando.Descricao;
       tarefaEncontrada.Concluida = tarefaEditando.Concluida;

       return RedirectToAction("Index");
    }


     public IActionResult Deletar(int Id)
    {
        Tarefa novaTarefa = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (novaTarefa == null)
            return NotFound();

        return View(novaTarefa);

    }

    [HttpPost]

    public IActionResult DeletarConfirmaram(int Id)
    {
        Tarefa tarefaEncontrada = _tarefas.FirstOrDefault(t => t.Id == Id);
        if (tarefaEncontrada == null)
            return NotFound();

       tarefaEncontrada.Descricao = tarefaEditando.Descricao;
       tarefaEncontrada.Concluida = tarefaEditando.Concluida;

       return RedirectToAction("Index");
    }


}