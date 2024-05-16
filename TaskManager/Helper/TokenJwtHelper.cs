namespace TaskManager.Helper;

public class TokenJwtHelper
{
    private IConfiguration _configuration;

    public TokenJwtHelper(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    /*
     
        public string GenerateToken(Usuario usuario)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()), 
                new Claim(ClaimTypes.Role, usuario.IdRol.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var securityToken = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(60),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(securityToken);


        }
        
    */
}