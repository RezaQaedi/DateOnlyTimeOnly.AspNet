using MD.PersianDateTime.Standard;

namespace DateOnlyTimeOnly.AspNet.Converters;

public class PersianDateTimeTypeConverter : StringTypeConverterBase<PersianDateTime>
{
    protected override PersianDateTime Parse(string s)
    {
        return PersianDateTime.Parse(s.Replace("T", " "));
    }

    protected override string ToIsoString(PersianDateTime source)
    {
        return source.ToString("yyyy-MM-ddTHH:mm:ss");
    }
}

