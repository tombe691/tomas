#include "graphics.h"

void main (void) {
  int gd = DETECT, gm;
  initgraph(&gd, &gm, "");
  line(0, 0, 639, 479);
  closegraph();
}
