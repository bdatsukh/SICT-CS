/*#include <gl/glut.h>
#include<math.h>


void  display() {
    glClear(GL_COLOR_BUFFER_BIT);
    glColor3f(0.0, 1.0, 0.0);
    
    float x0, x1, y0, y1;
    float alpha = 144.0f * 3.14f / 180.0f;
    
    x0 = 0.0f; 
    y0 = 0.5f;
    
    glBegin(GL_LINE_LOOP);
    glVertex2f(x0, y0);
    
    for (int i = 1; i <= 4; i++) {
        x1 = x0 * (float)cos(alpha) - y0 * (float)sin(alpha);
        y1 = x0 * (float)sin(alpha) + y0 * (float)cos(alpha);
        glVertex2f(x1, y1);
        x0 = x1; 
        y0 = y1;
    }

    glEnd();
    glFlush();
}

int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitWindowPosition(200, 100);
    glutCreateWindow("Green Triangle");
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}*/