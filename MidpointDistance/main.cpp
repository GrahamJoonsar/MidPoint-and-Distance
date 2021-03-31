#include <iostream>
#include "midpointDistance.h"

using namespace std;

int main(){
    Vector2 midpoint = midpoint2D(Vector2{0, 0}, Vector2{5, 5});
    float distance = distance2D(Vector2{0, 0}, Vector2{3, 4});
    cout << "Midpoint is: " << midpoint.x << ", " << midpoint.y << endl;
    cout << "Distance is: " << distance;
}