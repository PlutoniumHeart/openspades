/*
 Copyright (c) 2013 yvt
 
 This file is part of OpenSpades.
 
 OpenSpades is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.
 
 OpenSpades is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.
 
 You should have received a copy of the GNU General Public License
 along with OpenSpades.  If not, see <http://www.gnu.org/licenses/>.
 
 */


uniform sampler2D texture;

varying vec4 texCoord1;
varying vec4 texCoord2;

void main() {
    // generated by ./1dgaussGen.rb
    // pixelShift is texture coord shift / texture pixel
    const float pixelShift = 1.;
    const float shift1 = pixelShift * -2.30654399138844;
    const float scale1 = 0.178704407070903;
    const float shift2 = pixelShift * -0.629455560633963;
    const float scale2 = 0.321295592929097;
    const float shift3 = pixelShift * 0.629455560633963;
    const float scale3 = 0.321295592929097;
    const float shift4 = pixelShift * 2.30654399138844;
    const float scale4 = 0.178704407070903;
    
    gl_FragColor = texture2D(texture, texCoord1.xy) * scale1;
    gl_FragColor += texture2D(texture, texCoord1.zw) * scale2;
    gl_FragColor += texture2D(texture, texCoord2.xy) * scale3;
    gl_FragColor += texture2D(texture, texCoord2.zw) * scale4;
}

