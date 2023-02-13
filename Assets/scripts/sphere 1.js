function setup() {
  createCanvas(400, 400, WEBGL);
  noStroke()
  debugMode()
  //noLoop()
  //fill(40)
  phi = (1 + sqrt(5)) / 2
  
}

function spiral(numPoints, turnFrac, r, power){
  for (i = 0; i < numPoints; i++){
  let dst = (i/ (numPoints))** power
  let angle = 2 * PI * turnFrac * i
  dst = dst*PI
  
  let x = cos(angle) * sin(dst) * r
  let y = cos(dst)*r
  let z = sin(angle) * sin(dst) * r
  translate(x,y,z)
  sphere(5)
  translate(-x, -y, -z)
  }
  
}
var m = 0

function draw() {
  background(220);
  //translate(200, 200, 200)
  orbitControl()
  spiral(mouseX, phi, 200, 1)
  //print(mouseX)
  m ++
  if (m == 40000){m = 0}
}