/*#include <GL\freeglut.h>
GLfloat xRotated, yRotated, zRotated;
bool b = false;
void keyboard(unsigned char key, int x, int y) {
	switch (key) {
	case '+':
		b = true;
		break;
	case '-':
		b = false;
		break;
	}
}
void redisplayFunc(void)
{
	// buffer tseverleh
	glClear(GL_COLOR_BUFFER_BIT);

	glLoadIdentity();
	// translate the draw by z = -4.0
	// z utgiig -8.0aas bagasgaval het jijig esvel hol bolno.
	glTranslatef(0.0, 0.0, -5.0);
	// red
	glColor3f(0.9, 0.0, 0.0);
	// x huvid translation
	glRotatef(xRotated, 1.0, 0.0, 0.0);
	// rotation Y
	glRotatef(yRotated, 0.0, 1.0, 0.0);
	// rotation Z
	glRotatef(zRotated, 0.0, 0.0, 1.0);
	// scaling
	glScalef(1.0, 1.0, 1.0);
	// built-in (glut library) function , cube zurah.
	glutWireCube(1.0);
	// Flush buffers to screen
	glFlush();
	// sawp buffers (double buffering ashiglaj bgaa) (zuraad hiih zuraad hiih hadgalah)
	glutSwapBuffers();
}
void reshapeFunc(int x, int y)
{
	if (y == 0 || x == 0) return; //Nothing is visible uyd return hiigdene

	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	//harah ontsog:40
	//clipping hiih oiriin zai: 0.5
	// clipping holiin zai: 20.0
	gluPerspective(40.0, (GLdouble)x / (GLdouble)y, 0.5, 20.0);
	glMatrixMode(GL_MODELVIEW);
	glViewport(0, 0, x, y);
}
void idleFunc(void)
{
	// rotation by x
	if (b){
		yRotated += 0.03;
	}
	else {
		xRotated += 0.03;
	}
		
	// yRotated += 0.01;
	// zRotated += 0.01;
	redisplayFunc();
}
int main(int argc, char** argv)
{
	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_DOUBLE | GLUT_RGB);
	glutInitWindowSize(350, 350);
	glutCreateWindow("Cube3d animation");

	glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);

	xRotated = yRotated = zRotated = 0.0;
	glClearColor(0.0, 0.0, 0.0, 0.0);

	glutDisplayFunc(redisplayFunc);
	glutReshapeFunc(reshapeFunc);
	glutIdleFunc(idleFunc);
	glutKeyboardFunc(keyboard);
	glutMainLoop();
	return 0;
}*/