/*#include <gl/glut.h>
#include<math.h>

struct Point {
    float x;
    float y;
};

void drawLine(Point a, Point b) {
    glVertex2f(a.x, a.y);
    glVertex2f(b.x, b.y);
}

Point midPoint(Point a, Point b) {
    Point result;
    float k = 0.05f;

    result.x = (a.x + k * b.x) / (1 + k);
    result.y = (a.y + k * b.y) / (1 + k);

    return result;
}

void  display() {
    glClear(GL_COLOR_BUFFER_BIT);
    glColor3f(0.0, 1.0, 0.0);

    Point a, b, c, d;
    a.x = -0.8f;
    a.y = 0.8f;

    b.x = 0.8f;
    b.y = 0.8f;

    c.x = 0.8f;
    c.y = -0.8f;

    d.x = -0.8f;
    d.y = -0.8f;

    glBegin(GL_LINES);

    Point a1, b1, c1, d1;
    for (int i = 0; i < 40; i++) {
        drawLine(a, b);
        drawLine(b, c);
        drawLine(c, d);
        drawLine(d, a);

        a1 = midPoint(a, b);
        b1 = midPoint(b, c);
        c1 = midPoint(c, d);
        d1 = midPoint(d, a);

        a = a1;
        b = b1;
        c = c1;
        d = d1;
    }
    glEnd();

    glFlush();
}

int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitWindowPosition(200, 100);
    glutCreateWindow("Nested square by Batsukh");
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}*/