using System.Diagnostics;

namespace CodedUI.Practices.Pages
{
    public abstract class BasePage<TMap, TValidator> 
        where TMap : BaseMap 
        where TValidator : BaseValidator<TMap>
    {
        internal TMap Map { get; set; }
        internal TValidator Validator { get; set; }

        internal BasePage(TMap map, TValidator validator)
        {
            Map = map;
            Validator = validator;
        }

        public Process WindowProcess
        {
            get
            {
                return Map.BrowserProcess;
            }
        }

        internal BasePage()
        {

        }
    }
}