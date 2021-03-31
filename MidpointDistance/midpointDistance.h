#pragma once
#include <math.h>

// Defining structs
// 2 dimensional point
struct Vector2
{
  float x;
  float y;
};

// 3 dimensional point
struct Vector3
{
  float x;
  float y;
  float z;
};

// Returns the midpoint of two 2 dimensional points
Vector2 midpoint2D(Vector2 pointOne, Vector2 pointTwo){
    return Vector2{(pointOne.x + pointTwo.x)/2, (pointOne.y + pointTwo.y)/2};
}

// Returns the midpoint of two 3 dimensional points 
Vector3 midpoint3D(Vector3 pointOne, Vector3 pointTwo){
    return Vector3{(pointOne.x + pointTwo.x)/2, (pointOne.y + pointTwo.y)/2, (pointOne.z + pointTwo.z)/2};
}

// Returns the distance between two points
float distance2D(Vector2 pointOne, Vector2 pointTwo){
    return sqrt(pow(pointOne.x - pointTwo.x, 2) + pow(pointOne.y - pointTwo.y, 2));
}

// Returns the distance between two points
float distance3D(Vector3 pointOne, Vector3 pointTwo){
    return sqrt(pow(pointOne.x - pointTwo.x, 2) + pow(pointOne.y - pointTwo.y, 2) + pow(pointOne.z - pointTwo.z, 2));
}