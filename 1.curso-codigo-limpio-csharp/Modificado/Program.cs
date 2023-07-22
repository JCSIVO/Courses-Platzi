// using System;
// using System.Collections.Generic;

// namespace ToDo;

    //internal class Program
    
     List<string> TaskList  = new List<string>();

        //static void Main(string[] args)
        
            // TaskList = new List<string>();
            int menuSelected = 0;
            do
            {
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)menuSelected != Menu.Exit);
        
        /// <summary>
        /// Show the options for Tasks, 1. Nueva tarea 
        /// </summary>
        /// <returns>Returns option selected by user</returns>
        int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            string menuSelected = Console.ReadLine();
            return Convert.ToInt32(menuSelected);
        }

        void ShowMenuRemove()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");

                ShowTaskList(); // Esta función sustituye a la de abajo ShowMenuTaskList
                //ShowMenuTaskList();
                // Eliminamos esta parte del código por el principio DRY
                /*for (int i = 0; i < TaskList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
                }
                Console.WriteLine("----------------------------------------");*/

                string OptionToRemove = Console.ReadLine();

                // Remove one position because the array starts in 0
                int indexToRemove = Convert.ToInt32(OptionToRemove) - 1;

                if (indexToRemove > (TaskList.Count -1) || indexToRemove < 0)
                    Console.WriteLine("Número de tarea seleccionado no es válido");
                else
                {
                    if (indexToRemove > -1 && TaskList.Count > 0)
                    {
                        string task = TaskList[indexToRemove];
                        TaskList.RemoveAt(indexToRemove);
                        Console.WriteLine($"Tarea {task} eliminada");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al eliminar la tarea");
                // ex.Message
            }
        }

        void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string PendingTask = Console.ReadLine();
                if (string.IsNullOrEmpty(PendingTask)== true)
                {
                    Console.WriteLine("Debe de introducir el nombre de la tarea");
                }
                else
                {
                    TaskList.Add(PendingTask);
                    Console.WriteLine("Tarea registrada");

                }
            }
            catch (Exception ex)
            {   
                Console.WriteLine("Ha ocurrido un error al registrar la tarea");
            }
        }

        void ShowMenuTaskList()
        {
            // if (TaskList == null || TaskList.Count == 0)
            if (TaskList?.Count > 0)
            {
                ShowTaskList();
                /*Console.WriteLine("----------------------------------------");
                for (int i = 0; i < TaskList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
                }
                Console.WriteLine("----------------------------------------");*/
            } 
            else
            {
                Console.WriteLine("No hay tareas por realizar");
            }
        }
    void ShowTaskList()
    {
        Console.WriteLine("----------------------------------------");
        var indexTask = 0; // Otra opción inicializar la variable a 1 y luego el postIncremento
        TaskList.ForEach(p => Console.WriteLine($"{++indexTask} . {p}"));
                /*for (int i = 0; i < TaskList.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + TaskList[i]);
                }*/
                Console.WriteLine("----------------------------------------");
    }
    
    public enum Menu
    {
        Add = 1,
        Remove = 2,
        List = 3,
        Exit = 4
    }