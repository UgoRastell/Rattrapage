namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string AvatarUrl { get; set; } 

        public string GetGravatarUrl()
        {
            var emailHash = ComputeMD5Hash(Email.Trim().ToLower());
            return $"https://www.gravatar.com/avatar/{emailHash}";
        }

        private string ComputeMD5Hash(string input)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }

}
