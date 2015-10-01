#include "PDP_11_memory.h"
#include <malloc.h>
#include "stdafx.h"

status_t PDP_11_memory_init(PDP_11_memory* memory) {
	memory->start_pos = malloc(MEMORY_SIZE);
	memory->start_RAM_pos = memory->start_pos;
	memory->start_VRAM_pos = (void*)((int)memory->start_RAM_pos + RAM_SIZE);	//
	memory->start_ROM_pos = (void*)((int)memory->start_VRAM_pos + VRAM_SIZE);	// @TODO: improve addreses initialize
	memory->start_IO_pos = (void*)((int)memory->start_ROM_pos + ROM_SIZE);		//

	memory->all_memory_size = MEMORY_SIZE;
	memory->RAM_size = RAM_SIZE;
	memory->VRAM_size = VRAM_SIZE;
	memory->ROM_size = ROM_SIZE;
	memory->IO_size = IO_SIZE;

	return 0;
}

status_t PDP_11_memory_read_byte(addres_t addr, PDP_11_memory* memory, byte_t* buffer) {
	byte_t* abs_addr = (byte_t*)((int)memory->start_pos + (int)addr);
	*buffer = *abs_addr;
	
	return 0;
}

status_t PDP_11_memory_write_byte(addres_t addr, PDP_11_memory* memory, byte_t buffer) {
	byte_t* abs_addr = (byte_t*)((int)memory->start_pos + (int)addr);
	*abs_addr = buffer;

	return 0;
}