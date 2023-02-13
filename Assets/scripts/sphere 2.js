function setup() {
  createCanvas(400, 400, WEBGL);
  noStroke()
  fill(30)
  phi = (1 + sqrt(5)) / 2
  
}

function spiral(numPoints, turnFrac, r){
  for (i = 0; i < numPoints; i++){
    let t = i / (numPoints - 1)
    let dst = acos(1 - 2 * t)
    let angle = 2 * PI * turnFrac * i
    
    let x = cos(angle) * sin(dst) * r
    let y = sin(angle) * sin(dst) * r
    let z = cos(dst)*r
    
    translate(x,y,z)
    sphere(5)
    translate(-x, -y, -z)
  }
  
}
var m = 0

function draw() {
  background(220);
  orbitControl()
  spiral(400,  m/20000, 200) //turnFrac = phi, numPoints = detail
  m ++
  if (m == 20000){m = 0}
}