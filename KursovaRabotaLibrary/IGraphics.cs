using System.Drawing;

namespace KursovaRabotaLibrary
{
    public interface IGraphics
    {
        void DrawRectangle(Color colorBorder, Color colorFill, int x, int y, int width, int height);
        void DrawCircle(Color colorBorder, Color colorFill, int x, int y, int width, int height);
        void DrawSquare(Color colorBorder, Color colorFill, int x, int y, int width);


    }
}
