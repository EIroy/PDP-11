#include "PDP_11_types.h"

#define MEMORY_SIZE 0x8000	//
#define RAM_SIZE	0x2000	//
#define VRAM_SIZE	0x2000	// maybe move to other file
#define ROM_SIZE	0x3C00	//
#define IO_SIZE		0x0400	//

typedef struct _PDP_11_memory {
	void* start_pos;

	void* start_RAM_pos;
	void* start_VRAM_pos;
	void* start_ROM_pos;
	void* start_IO_pos;

	size_t all_memory_size;

	size_t RAM_size;
	size_t VRAM_size;
	size_t ROM_size;
	size_t IO_size;

	size_t ROM_loader_sec_size; //locate in the beginnig of ROM
} PDP_11_memory;

status_t PDP_11_memory_init(PDP_11_memory* memory);
status_t PDP_11_memory_read_byte(addres_t addr, PDP_11_memory* memory, byte_t* buffer);
status_t PDP_11_memory_write_byte(addres_t addr, PDP_11_memory* memory, byte_t buffer);