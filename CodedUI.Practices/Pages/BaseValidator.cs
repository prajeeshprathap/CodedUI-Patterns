namespace CodedUI.Practices.Pages
{
    public abstract class BaseValidator<TMap> where TMap : BaseMap
    {
        internal TMap Map { get; set; }

        internal BaseValidator(TMap map)
        {
            Map = map;
        }

        internal BaseValidator()
        {
        }
    }
}