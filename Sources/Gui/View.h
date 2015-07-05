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

#pragma once

#include <Core/RefCountedObject.h>
#include <Core/Math.h>

namespace spades {
    namespace gui {
        class View: public RefCountedObject {
        protected:
            virtual ~View() {}
        public:
            View(){}
            
            virtual void MouseEvent(float x, float y) = 0;
            virtual void KeyEvent(const std::string&,
                                  bool down) = 0;
            virtual void TextInputEvent(const std::string&) = 0;
            virtual void TextEditingEvent(const std::string&,
                                          int start, int len) = 0;
            virtual bool AcceptsTextInput() { return false; }
            virtual AABB2 GetTextInputRect() { return AABB2(); }
            virtual bool NeedsAbsoluteMouseCoordinate() { return false; }
            virtual void WheelEvent(float x, float y) = 0;
            
            virtual void RunFrame(float dt) = 0;
            
            virtual void Closing() = 0;
            
            virtual bool WantsToBeClosed() { return false; }
        };
    }
}
