/*#include <gl/glut.h>
#include <math.h>
#include<iostream>

using namespace std;

float cx = 0, cy = 0, p = 1;
double xa[6];
double ya[6];
double xa1[6];
double ya1[6];
double xa2[6] = { 50, 52, 56, 56, 52, 50 };
double ya2[6] = { -5, -3, -3, 3, 3, 5 };

void drawCircle(GLfloat radius) {
	glBegin(GL_LINE_LOOP);
	for (int i = 0; i < 365; i++)
	{
		float theta = 2.0f * 3.1415926f * float(i) / float(365);
		float x1 = radius * cosf(theta);
		float y1 = radius * sinf(theta);
		glVertex2f(x1, y1);
	}
	glEnd();
}

void rotate(int angle) {
	double rad = angle * 3.14159 / 180;
	for (int i = 0; i < 6; i++) {
		xa1[i] = (xa[i]) * cos(rad) - sin(rad) * (ya[i]);
		ya1[i] = sin(rad) * (xa[i]) + cos(rad) * (ya[i]);
	}
}

void rotate1(float angle) {
	double rad = angle * 3.14159 / 180;
	for (int i = 0; i < 6; i++) {
		xa[i] = (xa2[i]) * cos(rad) - sin(rad) * (ya2[i]);
		ya[i] = sin(rad) * (xa2[i]) + cos(rad) * (ya2[i]);
	}
}

void tooth() {
	glBegin(GL_LINE_LOOP);
	for (int i = 0; i < 360; i = i + 12) {
		rotate(i);
		for (int j = 0; j < 6; j++) {
			glVertex2d(xa1[j], ya1[j]);
		}
	}
	glEnd();
}

void move(int a) {
	glutPostRedisplay();
	glutTimerFunc(1000 / 60, move, 0);
	p = p + 2.0f;
	rotate1(p);
	if (p == 360) {
		p = 1;
	}
}

void display() {
	glClear(GL_COLOR_BUFFER_BIT);
	glColor3f(0, 1, 0);
	tooth();
	drawCircle(10);
	glutSwapBuffers();
}

void reshape(int w, int h) {
	glViewport(0, 0, (GLsizei)w, (GLsizei)h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	gluOrtho2D(80, -80, -80, 80);
	glMatrixMode(GL_MODELVIEW);
}

int main(int argc, char** argv) {
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE);
	glutInitWindowPosition(0, 0);
	glutInitWindowSize(500, 500);
	glutCreateWindow("A moving gear wheel");
	glutDisplayFunc(display);
	glutReshapeFunc(reshape);
	glutTimerFunc(0, move, 0);
	glClearColor(0, 0, 0, 0);
	glutMainLoop();
}*/