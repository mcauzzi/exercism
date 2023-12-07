public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var res = phoneNumber.Contains('+') ? phoneNumber.Substring(phoneNumber.IndexOf(" ")) : phoneNumber;

        res = res.Replace("-", string.Empty).Replace("(", string.Empty)
            .Replace(")", string.Empty).Replace(" ", string.Empty).Replace(".", string.Empty);

        if (res[0] == '0' || res.Length > 11 || res.Length < 10)
        {
            throw new System.ArgumentException();
        }

        if (res[0] == '1')
        {
            if (res.Length == 11)
            {
                if (res[1] == '0' || res[1] == '1' || res[4] == '1')
                {
                    throw new System.ArgumentException();
                }

                res = res.Replace("1", string.Empty);
            }
            else
            {
                throw new System.ArgumentException();
            }
        }

        if (res[3] == '0' || res[3] == '1' || res.Length == 11)
        {
            throw new System.ArgumentException();
        }

        return res;
    }
}