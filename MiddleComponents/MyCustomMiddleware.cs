namespace harizcustomemiddleware.MiddleComponents;

public class MyCustomMiddleware
{
    private readonly RequestDelegate _next;

    public MyCustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        await context.Response.WriteAsync("MyCustomMiddleware: Before calling next\r\n");
        await _next(context);
        await context.Response.WriteAsync("MyCustomMiddleware: After calling next\r\n");
    }
}