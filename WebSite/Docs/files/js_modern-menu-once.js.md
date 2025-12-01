# File: js/modern-menu-once.js

- One-time initializer for modern drawer menu.
- Lazy-fetches menu JSON from /Pages/MenuApi.aspx/GetMenuTree.
- Renders accessible tree with expand/collapse, filter, badges, icons.
- Focus trap, ESC/backdrop close. Guard via window.__modernMenuOnceMounted.

### Function: initModernMenuOnce
- Signature: function initModernMenuOnce()
- Purpose: Initialize drawer, fetch menu JSON, render, and wire a11y behaviors.
- Returns: void
- Called by: first click on #menuToggleBtn
