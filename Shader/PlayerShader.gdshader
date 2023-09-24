shader_type canvas_item;

void vertex() {
	// Called for every vertex the material is visible on.
}

void fragment() {
	vec4 tex = texture(TEXTURE, UV);
	
	COLOR = mix(tex, vec4(0.1,0.25,0.25,0.3), 0.4);
}

void light() {
	// Called for every pixel for every light affecting the CanvasItem.
}
