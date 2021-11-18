/*#include <iostream>
#include <gl/glut.h>
#include <math.h>

void cube() {
    glColor3f(0, 1, 1);
    glScalef(1.0, 1.0, 1.0);
    glutWireCube(1.0);
}

void one(double w, double h, double d) {
    glPushMatrix();
    glTranslatef(-0.5*w, 0, 0);
    glScalef(w, h, d);
    cube();
    glPopMatrix();
}

void two(double w, double h, double d) {
    glPushMatrix();
    glTranslatef(-1 * w, 0., 0.);
    one(w, h, d);
    glTranslatef(2 * w, 0., 0.);
    one(w, h, d);
    glPopMatrix();
}

void five(double w, double h, double d) {
    //M нь -8w/h аар зүүн тийш shear хийх матриц
    GLfloat M[16] = { 1, 0, 0, 0,
           (-2 * w / h), 1, 0, 0,
                      0, 0, 1, 0,
                      0, 0, 0, 1 };
    glPushMatrix();
    glTranslatef(-w, 0., 0.);
    glMultMatrixf(M);
    one(w, h, d);
    glPopMatrix();
    //M нь 8w/h аар баруун тийш shear хийх матриц
    GLfloat M2[16] = { 1, 0, 0, 0,
             (2 * w / h), 1, 0, 0,
                       0, 0, 1, 0,      
                       0, 0, 0, 1 };
    glPushMatrix();
    glTranslatef(w, 0., 0.);
    glMultMatrixf(M2);
    one(w, h, d);
    glPopMatrix();
}

void ten(double w, double h, double d) {
    //M нь зүүн тийш shear хийх матриц (in x by -4w/h * y)
    GLfloat M[16] = { 1, 0, 0, 0,
           (-4 * w / h), 1, 0, 0,
                      0, 0, 1, 0,
                      0, 0, 0, 1 };
    glPushMatrix();
    glMultMatrixf(M);
    one(w, h, d);
    glPopMatrix();
    // M нь зүүн тийш shear хийх матриц (in x by 4w/h * y)
    GLfloat M2[16] = { 1, 0, 0, 0,
             (4 * w / h), 1, 0, 0,
                       0, 0, 1, 0, 
                       0, 0, 0, 1 };
    glPushMatrix();
    glMultMatrixf(M2);
    one(w, h, d);
    glPopMatrix();
}

void  display() {
    one(0.1, 0.5, 1);
    glPopMatrix();
    
    glPushMatrix();
    glTranslatef(0.5, 0.5, 0);
    two(0.1, 0.5, 1);
    glPopMatrix();

    glPushMatrix();
    glTranslatef(-0.5, -0.5, 0);
    five(0.1, 0.5, 1);
    glPopMatrix();

    glPushMatrix();
    glTranslatef(0.5, -0.5, 0);
    ten(0.1, 0.5, 1);
    glPopMatrix();

    glFlush();
}

int main(int argc, char** argv)
{
    glutInit(&argc, argv);
    glutInitWindowPosition(200, 100);
    glutInitWindowSize(350, 350);
    glutCreateWindow("3D Cubes by Batsukh");
    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);
    glClearColor(0.0, 0.0, 0.0, 0.0);
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}*/