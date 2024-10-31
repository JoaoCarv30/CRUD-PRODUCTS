var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Configuração para o Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona os serviços de controllers (para detectar o ProductController)
builder.Services.AddControllers();

var app = builder.Build();

// Configuração para exibir o Swagger na interface do usuário
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Mapear os controllers para o Swagger detectar as rotas
app.MapControllers();

app.Run();
