using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ToDoList.Pages
{
    public class ContactModel : PageModel
    {
        public void OnGet()
        {
          //  LoadInitData();

        }

        private void LoadInitData()
        {
            this.OurName = "A&A soft";
            this.OurPhone = "1-800-900-700";
        }

        public void OnPost()
        {
            LoadInitData();
            LikeCount++;
        }

        public void OnPostAddTodo()
        {
            LoadInitData();
            if (MyTodos==null)
                MyTodos = new List<string>();
            MyTodos.Add(TodoItemText);
        }

        [BindProperty]

        public List<string> MyTodos { get; set; }

        [BindProperty ]
        public int LikeCount { get; set; }

        [BindProperty]
        public string TodoItemText { get; set; }

        public string OurPhone { get; set; }
        public string OurName { get; set; }
    }
}
