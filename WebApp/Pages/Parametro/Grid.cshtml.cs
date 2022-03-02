using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;


namespace WebApp.Pages.Parametro
{
    public class GridModel : PageModel
    {


 
        private readonly IParametroService parametroService;

        public GridModel(IParametroService parametroService)
        {
            
            this.parametroService = parametroService;
        }

        public IEnumerable<ParametroEntity> GridList { get; set; } = new List<ParametroEntity>();

        public string Mensaje { get; set; } = "";

        public async Task<IActionResult> OnGet()
        {
            try
            {

                GridList = await parametroService.Get();


                if (TempData.ContainsKey("Msg"))
                {

                    Mensaje = TempData["Msg"] as string;

                }

                TempData.Clear();


                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }

        public async Task<IActionResult> OnGetEliminar(int id)
        {
            try
            {

                var result = await parametroService.Delete(new()
                {
                    IdParametro = id

                }

                 );


                if (result.CodeError != 0)
                {

                    throw new Exception(result.MsgError);

                }


                TempData["Msg"] = "El registro se elimino correctamente";


                return Redirect("Grid");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }


        }

















    }
}
